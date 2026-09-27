using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using YooAsset;

public class Volibear : Enemy
{
    public float distance;
    public float attackDistance = 3f;
    void OnEnable()
    {
        EventCenter.Instance.AddListener(EventType.PlayerDead, EnemyWin);
    }
    void OnDisable()
    {
        EventCenter.Instance.RemoveListener(EventType.PlayerDead, EnemyWin);
    }
    protected override void Start()
    {
        base.Start();
        EventCenter.Instance.TriggerEvent<float>(EventType.EnemyHPChange, nowHP/data.maxHP);
    }
    protected override void Update()
    {
        if (target != null) base.Update();
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
        if (canCast && nowTCD >= data.TCD && nowHP/data.maxHP < 0.25f)
        {
            CastT();
        }
        else if (canCast && nowRCD >= data.RCD && nowHP/data.maxHP < 0.55f && distance >= attackDistance)
        {
            CastR();
        }
        else if (canCast && nowECD >= data.ECD && nowHP/data.maxHP < 0.8f && distance <= attackDistance)
        {
            CastE();
        }
        else if (canCast && nowQCD >= data.QCD && distance <= attackDistance)
        {
            CastQ();
        }
    }
    
    protected override void CastQ()
    {
        base.CastQ();
        animator.SetTrigger("Q");
        nowQCD = 0;
        BanMove();
        BanCast();
        BanAttack();
    }
    public async void QDamage()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward * 1.5f,
                               new Vector3(1.5f, 1f, 1.5f), transform.rotation, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 1.5f);
        }
        await AudioManager.Instance.PlaySound("Volibear_Q");
    }
    protected override void CastE()
    {
        base.CastE();
        animator.SetTrigger("E");
        nowECD = 0;
        BanMove();
        BanCast();
        BanAttack();
    }
    public async void EDamage1()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward * 1.5f,
                               new Vector3(1.5f, 1f, 1.5f), transform.rotation, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 0.75f);
        }
        await AudioManager.Instance.PlaySound("Volibear_E1");
    }
    public async void EDamage2()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward * 1.5f,
                               new Vector3(1.5f, 1f, 1.5f), transform.rotation, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 0.75f);
            nowHP += 0.1f * data.maxHP;
            EventCenter.Instance.TriggerEvent<float>(EventType.EnemyHPChange, nowHP/data.maxHP);
        }
        await AudioManager.Instance.PlaySound("Volibear_E2");
    }
    protected override async void CastR()
    {
        base.CastR();
        animator.SetTrigger("R");
        nowRCD = 0;
        BanMove();
        BanCast();
        BanAttack();
        await AudioManager.Instance.PlaySound("Volibear_R");
    }
    public async void RDamage()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position + transform.up,
                               10f, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 1.5f);
        }
    }
    protected override async void CastT()
    {
        base.CastT();
        animator.SetTrigger("T");
        nowTCD = 0;
        BanMove();
        BanCast();
        BanAttack();
        await AudioManager.Instance.PlaySound("Volibear_T");
        var token = this.GetCancellationTokenOnDestroy();
        ScaleTo(Vector3.one * 2f);
        nowAttack = data.attack * 2f;
        nowDefense = data.defense * 2f;
        await UniTask.WaitForSeconds(10f);
        if (this == null) return;
        nowAttack = data.attack;
        nowDefense = data.defense;
        ScaleTo(Vector3.one);
    }
    private async void ScaleTo(Vector3 target)
    {
        Vector3 start = transform.localScale;
        float t = 0f;
        while(t < 1.5f)
        {
            if (this == null) return;
            t += Time.deltaTime;
            transform.localScale = Vector3.Lerp(start, target, t / 1.5f);
            await UniTask.Yield(PlayerLoopTiming.Update);
        }
        transform.localScale = target;
    }
    public async void TDamage()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position + transform.up,
                               10f, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 5f);
        }
    }
    protected override void Move()
    {
        base.Move();
        Vector3 dir = target.position - transform.position;
        dir.y = 0;
        distance = dir.magnitude;
        if (!canMove) return;
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            Quaternion.LookRotation(dir),
            rotateSpeed * Time.deltaTime);
        float targetSpeed = 0;
        if (distance > attackDistance)
        {
            dir.Normalize();
            targetSpeed = maxSpeed;
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
    protected override void Attack()
    {
        nowAttackCD += Time.deltaTime * nowAttackSpeed;
        if (nowAttackCD >= data.attackCD) nowAttackCD = data.attackCD;
        if (canAttack && distance <= attackDistance && nowAttackCD >= data.attackCD)
        {
            animator.SetTrigger("attack");
            nowAttackCD = 0;
            animator.SetInteger("attackType", attackCount % attackTypeCount);
            attackCount++;
            animator.SetFloat("attackSpeed", nowAttackSpeed);
        }
    }
    public async void AttackDamage()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position + transform.up + transform.forward * 1.5f,
                               new Vector3(1.5f, 1f, 1.5f), transform.rotation, 1 << LayerMask.NameToLayer("Player"));
        foreach(var collider in colliders)
        {
            collider.GetComponent<Character>()?.Hurt(nowAttack * 1f);
        }
        await AudioManager.Instance.PlaySound("Volibear_Attack" + (attackCount - 1) % attackTypeCount);
    }
    public override void Hurt(float damage)
    {
        base.Hurt(damage);
        EventCenter.Instance.TriggerEvent<float>(EventType.EnemyHPChange, nowHP/data.maxHP);
    }
    public async void DeathSound()
    {
        await AudioManager.Instance.PlaySound("Volibear_Death");
    }
    protected override void Dead()
    {
        base.Dead();
        EventCenter.Instance.TriggerEvent(EventType.EnemyDead);
    }
    public async void WinSound()
    {
        await AudioManager.Instance.PlaySound("Volibear_Win");
    }
    async void EnemyWin()
    {
        isWin = true;
        animator.SetBool("isWin", true);
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
