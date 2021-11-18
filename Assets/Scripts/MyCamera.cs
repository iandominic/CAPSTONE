using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public float yAxis;
    public float xAxis;
    public float lookSensitivity = 0.2f;
    public float smoothTime = 0.9f;
    public Transform target;
    public float RotationMin = -80f;
    public float RotationMax = 80f;

    private Quaternion camRotation;
    private RaycastHit hit;
    private Vector3 camera_offset;


    Vector3 currentVel;
    Vector3 targetRotation;
    public FixedJoystick joystick;
    public FixedTouchField touchField;
    public bool enableMobileInputs = false;
    // Update is called once per frame
    void LateUpdate()
    {
        if (enableMobileInputs)
        {
            yAxis += touchField.TouchDist.x * lookSensitivity;
            xAxis -= touchField.TouchDist.y * lookSensitivity;
        }
        else
        {

        }

        xAxis = Mathf.Clamp(xAxis, RotationMin, RotationMax);
        
        targetRotation = Vector3.SmoothDamp(targetRotation, new Vector3(xAxis, yAxis), ref currentVel, smoothTime);
        transform.eulerAngles = targetRotation;
        transform.position = target.position - transform.forward * 5f;

       
    }
}
