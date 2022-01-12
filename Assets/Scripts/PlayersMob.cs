using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMob : Mob
{
    public int MaxHP = 10;
    public LayerMask enemyMask;
    public float range;
    Animator animator;

    

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        HP = MaxHP;
    }

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        Collider2D[] coll = Physics2D.OverlapCircleAll(transform.position, range, enemyMask);

        if (coll.Length > 0)
        {
            Attack(coll);
        }
    }

    private void Attack(Collider2D[] coll)
    {
        animator.SetBool("Attack", true);
        foreach(Collider2D col in coll)
        {
            col.GetComponent<Mob>().TakeDamage(1);
        }
        //Die();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
