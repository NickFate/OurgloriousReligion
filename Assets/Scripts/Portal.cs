using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    float _timer = 0;
    float currentTime = 7;
    public Enemy[] en;
    public GameObject point;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > currentTime)
        {
            GameObject A = Instantiate<GameObject>(en[0].gameObject);
            A.transform.position = point.transform.position;
            _timer = 0;
        }
    }
}
