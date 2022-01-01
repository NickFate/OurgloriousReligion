using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMob : Mob
{
    int MaxHP = 10;

    private void Awake()
    {
        HP = MaxHP;
    }

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
    }

}
