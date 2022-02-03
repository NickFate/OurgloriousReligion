using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector2 startPos;
    private float TargetPos;
    private Camera cam;

    public float speed;

    void Start()
    {
        cam = GetComponent<Camera>();
        TargetPos = cam.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            startPos = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (Input.GetMouseButton(0))
        {
            float pos = cam.ScreenToWorldPoint(Input.mousePosition).x - startPos.x;
            TargetPos = Mathf.Clamp(transform.position.x - pos, -1, 1 * 8);
        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, TargetPos, speed * Time.deltaTime), transform.position.y, transform.position.z);
    }
}
