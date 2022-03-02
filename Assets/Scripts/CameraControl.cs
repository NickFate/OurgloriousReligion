using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Vector2 startPos;
    private Camera cam;
    private float targetPos;

    public float speed;

    private void Start()
    {
        cam = GetComponent<Camera>();
        targetPos = cam.transform.position.x;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            float pos = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            //transform.position = new Vector3(Mathf.Clamp(transform.position.x - pos, 0, 16), transform.position.y, transform.position.z);
            targetPos = Mathf.Clamp(transform.position.x - pos, 0, 16);
        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);

    }
}
