using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    //for moving camera with mouse
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Start()
    {
        offset = transform.position - player.transform.position;
        offset.y = 5;
    }

    void Update()
    {
        //move camera with mouse
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;   
    }
}
