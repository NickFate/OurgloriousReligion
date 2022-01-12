using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Mob
{
    int Hp = 1;
    public LayerMask enemyMask;



    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
        Collider2D[] coll = Physics2D.OverlapCircleAll(transform.position, 2, enemyMask); 
    
        foreach (Collider2D coll2d in coll)
        {

        }
    }

    public override void Die()
    {
        Camera.main.GetComponent<Global>().AddMoney(1);
        base.Die();
    }

}
