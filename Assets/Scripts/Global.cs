using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    private int MP = 0;
    private int MP_ForTick = 1;

    private float _timer;

    public GameObject point;
    public Text MP_Value;

    void Start()
    {
        
    }


    void Update()
    {
        if (_timer > 1)
        {
            MP += MP_ForTick;
            MP_Value.text = MP.ToString("0.0");
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    public void CreateMob(Mob mob)
    {
        if (MP < mob.cost)
        {
            return;
        }
        MP -= mob.cost;
        GameObject MOB = Instantiate<GameObject>(mob.gameObject);
        MOB.transform.position = point.transform.position;
        MP_Value.text = MP.ToString("0.0");
    }

}
