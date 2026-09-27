using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using YooAsset;

public class Jax : Character
{
    protected Transform viewCameraTrans;
    protected bool isCounter;
    protected float counterDamage;
    void OnEnable()
    {
        EventCenter.Instance.AddListener(EventType.EnemyDead, PlayerWin);
    }
    void OnDisable()
    {
        EventCenter.Instance.RemoveListener(EventType.EnemyDead, PlayerWin);
    }
    protected override void Start()
    {
        base.Start();
        viewCameraTrans = Camera.main.transform;
        EventCenter.Instance.TriggerEvent<float>(EventType.PlayerHPChange, nowHP/data.maxHP);
        UpdateCD();
    }
    async void UpdateCD()
    {
        SkillCDData CDData = new SkillCDData();
        while (true)
        {
            if (this == null) return;
            CDData.SetData(nowQCD/data.QCD, nowECD/data.ECD, nowRCD/data.RCD, nowTCD/data.TCD);
            EventCenter.Instance.TriggerEvent<SkillCDData>(EventType.SkillCDChange, CDData);
            await UniTask.Yield(PlayerLoopTiming.Update);
        }
    }
    protected override void Move()
    {
        base.Move();
        if (canMove)
        {
            Vector3 camForward = viewCameraTrans.forward;
            camForward.y = 0f;
            camForward.Normalize();

            Vector3 camRight = viewCameraTrans.right;
            camRight.y = 0f;
            camRight.Normalize();

            Vector3 dir = Vector3.zero;
            if (Input.GetKey(KeyCode.W)) dir += camForward;
            if (Input.GetKey(KeyCode.S)) dir -= camForward;
            if (Input.GetKey(KeyCode.A)) dir -= camRight;
            if (Input.GetKey(KeyCode.D)) dir += camRight;
            float targetSpeed = 0;
            if (dir.sqrMagnitude > 0.001f)
            {
                dir.Normalize();
                targetSpeed = maxSpeed;
                transform.rotation = Quaternion.Slerp(
                    transform.rotation,
                    Quaternion.LookRotation(dir),
                    rotateSpeed * Time.deltaTime);
            }

            // 逐渐加速/减速
            nowSpeed = Mathf.MoveTowards(nowSpeed, targetSpeed, acceleration * Time.deltaTime);

            // 重力
            if (cc.isGrounded && verticalVelocity < 0f) verticalVelocity = -2f;
            verticalVelocity += gravity * Time.deltaTime;

            Vector3 velocity = dir * nowSpeed;
            velocity.y = verticalVelocity;
            cc.Move(velocity * Time.deltaTime);

            // 归一化速度给混合树
            animator.SetFloat("speed", nowSpeed / data.speed);
        }
    }
    protected override void Attack()
    {
        base.Attack();
        nowAttackCD += Time.deltaTime * nowAttackSpeed;
        if (canAttack && Input.GetMouseButton(0) && nowAttackCD >= data.attackCD)
        {
            animator.SetTrigger("attack");
            nowAttackCD = 0;
            animator.SetInteger("attackType", attackCount % attackTypeCount);
            attackCount++;
            animator.SetFloat("attackSpeed", nowAttackSpeed);
        }
    }
    protected override void CastSkills()
    {
        base.CastSkills();
        nowQCD += Time.deltaTime;
        nowECD += Time.deltaTime;
        nowRCD += Time.deltaTime;
        nowTCD += Time.deltaTime;
        if (nowQCD >= data.QCD) nowQCD = data.QCD;
        if (nowECD >= data.ECD) nowECD = data.ECD;
        if (nowRCD >= data.RCD) nowRCD = data.RCD;
        if (nowTCD >= data.TCD) nowTCD = data.TCD;
        if (canCast && Input.GetKeyDown(KeyCode.Q) && nowQCD >= data.QCD)
        {
            CastQ();
        }
        else if (canCast && Input.GetKeyDown(KeyCode.E) && nowECD >= data.ECD)
        {
            CastE();
        }
        else if (canCast && Input.GetKeyDown(KeyCode.R) && nowRCD >= data.RCD)
        {
            CastR();
        }
        else if (canCast && Input.GetKeyDown(KeyCode.T) && nowTCD >= data.TCD)
        {
            CastT();
        }
        if (isCounter)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                animator.SetTrigger("endR");
            }
        }

    }
    public async void AttackDamage()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward,
                                new Vector3(1f,1f,1f), transform.rotation, 1 << LayerMask.NameToLayer("Enemy"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(((attackCount - 1) % attackTypeCount) == 2 ? nowAttack * 1.2f : nowAttack);
        }
        await AudioManager.Instance.PlaySound("Jax_Attack" + (attackCount - 1) % attackTypeCount);
    }
    async protected override void CastQ()
    {
        base.CastQ();
        animator.SetTrigger("Q");
        nowQCD = 0;
        print("Q技能");
        await UniTask.WaitUntil(()=>!canCast);
        while (!canCast)
        {
            cc.Move(transform.forward * 15f * Time.deltaTime);
            await UniTask.Yield();
        }
    }
    public async void QDamage()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up * 0.5f,
                               new Vector3(1.5f, 0.5f, 1.5f), transform.rotation, 1 << LayerMask.NameToLayer("Enemy"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 0.5f);
        }
        await AudioManager.Instance.PlaySound("Jax_Q");
    }
    protected override void CastE()
    {
        base.CastE();
        animator.SetTrigger("E");
        nowECD = 0;
        print("E技能");
    }
    public async void EDamage()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward,
                               new Vector3(1f, 1f, 1f), transform.rotation, 1 << LayerMask.NameToLayer("Enemy"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 1.5f);
        }
        await AudioManager.Instance.PlaySound("Jax_E");
    }
    protected override void CastR()
    {
        base.CastR();
        animator.SetTrigger("R");
        nowRCD = 0;
        print("R技能");
    }
    public async void InR()
    {
        isCounter = true;
        counterDamage = 0;
        await AudioManager.Instance.PlaySound("Jax_R1");
    }
    public async void OutR()
    {
        isCounter = false;
        await AudioManager.Instance.PlaySound("Jax_R2");
    }
    public override void Hurt(float damage)
    {
        if (isCounter)
        {
            counterDamage += damage;
        }
        else
        {
            base.Hurt(damage);
            EventCenter.Instance.TriggerEvent<float>(EventType.PlayerHPChange, nowHP/data.maxHP);
        } 
        
    }
    public async void RDamage()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position + transform.up,
                               2f, 1 << LayerMask.NameToLayer("Enemy"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 0.5f + counterDamage * 0.5f);
        }
    }
    protected override async void CastT()
    {
        base.CastT();
        animator.SetTrigger("T");
        nowTCD = 0;
        print("T技能");
        await AudioManager.Instance.PlaySound("Jax_T");
        maxSpeed = data.speed * 1.5f;
        nowAttackSpeed = data.attackSpeed * 2f;
        attackTypeCount = 3;
        await UniTask.WaitForSeconds(10f);
        maxSpeed = data.speed;
        nowAttackSpeed = data.attackSpeed;
        attackTypeCount = 2;
    }
    public async void TDamage()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position + transform.up,
                               2f, 1 << LayerMask.NameToLayer("Enemy"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 0.5f);
        }
    }
    public async void DeathSound()
    {
        await AudioManager.Instance.PlaySound("Jax_Death");
    }
    protected override void Dead()
    {
        base.Dead();
        EventCenter.Instance.TriggerEvent(EventType.PlayerDead);
    }
    public async void WinSound()
    {
        await AudioManager.Instance.PlaySound("Jax_Win");
    }
    async void PlayerWin()
    {
        isWin = true;
        animator.SetBool("isWin", true);
        GameDataManager.Instance.nowPlayerData.passedLevelsId.Add(GameDataManager.Instance.nowLevelData.levelId);
        GameDataManager.Instance.SavePlayerDatas();
        await UniTask.WaitForSeconds(7.5f);
        UIManager.Instance.HidePanel<GamePanel>();
        var package = YooAssets.GetPackage("DefaultPackage");
        var handle = package.LoadSceneAsync("Scenes_Start");
        handle.Completed += async (handle) =>
        {
            handle.Release();
            await UIManager.Instance.SetCanvas();
            await UIManager.Instance.ShowPanel<StartPanel>();
            await AudioManager.Instance.PlayMusic("BackMusic_Start");
            Cursor.lockState = CursorLockMode.None;
        };
    }
}
