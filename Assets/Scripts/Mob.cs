using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    private protected int HP;

    public virtual void TakeDamage(int damage)
    {

        HP -= damage;

        if (HP < 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
