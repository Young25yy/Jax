using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterData data;
    public CharacterController cc;
    public Animator animator;
    
    protected float acceleration = 20f;
    protected float rotateSpeed = 12f;
    protected float gravity = -20f;
    protected float verticalVelocity;
    protected float nowAttack;
    protected float nowDefense;
    protected float nowHP;
    protected float nowSpeed;
    protected float maxSpeed;
    protected float nowQCD;
    protected float nowECD;
    protected float nowRCD;
    protected float nowTCD;
    protected float nowAttackSpeed;
    protected float nowAttackCD;
    protected int attackCount;
    protected int attackTypeCount;
    protected bool isDead;
    protected bool isWin;
    public bool canMove;
    public bool canAttack;
    public bool canCast;
    protected virtual void Start()
    {
        
        nowAttack = data.attack;
        nowDefense = data.defense;
        nowHP = data.maxHP;
        nowSpeed = 0;
        maxSpeed = data.speed;
        nowQCD = data.QCD;
        nowECD = data.ECD;
        nowRCD = data.RCD;
        nowTCD = data.TCD;
        nowAttackSpeed = data.attackSpeed;
        nowAttackCD = data.attackCD;
        attackCount = 0;
        attackTypeCount = 2;
        isDead = false;
        canMove = true;
        canAttack = true;
        canCast = true;
    }

    protected virtual void Update()
    {
        if (isDead || isWin) return;
        Move();
        CastSkills();
        Attack();
    }
    protected virtual void Attack()
    {
        
    }
    public virtual void Hurt(float damage)
    {
        if(nowHP <= 0) return;
        float realDamage = damage - nowDefense;
        if (realDamage < 0) realDamage = 0;
        nowHP -= realDamage;
        if(nowHP <= 0)
        {
            nowHP = 0;
            Dead();
        }
    }
    protected virtual void Dead()
    {
        isDead = true;
        animator.SetBool("isDead", isDead);
        print(data.name + "死掉了");
    }
    protected virtual void CastSkills()
    {
        
    }
    protected virtual void CastQ()
    {
        
    }
    protected virtual void CastE()
    {
        
    }
    protected virtual void CastR()
    {
        
    }
    protected virtual void CastT()
    {
        
    }
    protected virtual void Move()
    {
        
    }
    
    public void BanMove()
    {
        canMove = false;
        nowSpeed = 0f;
        animator.SetFloat("speed", nowSpeed / data.speed);
    }
    public void AllowMove()
    {
        canMove = true;
    }
    public void BanCast()
    {
        canCast = false;
    }
    public void AllowCast()
    {
        canCast = true;
    }
    public void BanAttack()
    {
        canAttack = false;
    }
    public void AllowAttack()
    {
        canAttack = true;
    }
}