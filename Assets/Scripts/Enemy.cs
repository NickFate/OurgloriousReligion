using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int Hp = 10;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
    }



}
