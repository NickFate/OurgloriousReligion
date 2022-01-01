using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public GameObject point;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void Create(Mob mob)
    {
        GameObject A = Instantiate<GameObject>(mob.gameObject);
        A.transform.position = point.transform.position;
    }
}
