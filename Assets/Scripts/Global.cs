using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
    private float Value = 0;
    private float ValueUpdate = 1.5f;
    
    float Timer;
    int Money = 0;

    public GameObject point;
    public Text CellText;
    public Text HpText;
    public Text MoneyText;


    void Start()
    {
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer > 1)
        {
            Value += ValueUpdate;
            Timer = 0;
            CellText.text = Value.ToString("0.0");
        }
    }

    public void Create(Mob mob)
    {
        int cost;
        if (mob.tag == "l")
        {
            cost = 10;
        }
        else
        {
            cost = 20;
        }
        if (Value < cost)
        {
            return;
        }
        Value -= cost;
        GameObject A = Instantiate<GameObject>(mob.gameObject);
        A.transform.position = point.transform.position;
        CellText.text = Value.ToString("0.0");
    }

    public void AddMoney(int value)
    {
        Money += 1;
        MoneyText.text = Money.ToString();
    }


}
