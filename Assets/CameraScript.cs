using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speedHorz = 3.0f;
    public float speedVert = 3.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        yaw += speedHorz* Input.GetAxis("Mouse X");
        pitch -= speedVert * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
