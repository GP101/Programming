using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public float _speed = 10.0f;
    public float _rotSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 forward = gameObject.transform.forward;
        forward *= Time.deltaTime * _speed * v;
        gameObject.transform.position += forward;

        Quaternion rot = new Quaternion();
        rot.SetAxisAngle(Vector3.up, h * _rotSpeed * Time.deltaTime);
        gameObject.transform.rotation *= rot;
    }
}
