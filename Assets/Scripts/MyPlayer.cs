using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    float smoothRotationTime = 0.25f;
    float currentVelocity;
    float moveSpeed = 3f;
    float currentSpeed;
    float speedVelocity;
    public bool enableMobileInputs = false;

    Transform cameraTransform;
    public FixedJoystick joystick;
    public ParticleSystem dust;



    private void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
   
        Vector2 input = Vector2.zero;

        if (enableMobileInputs)
        {
            input = new Vector2(joystick.input.x, joystick.input.y);
        }
        else
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        Vector2 inputDir = input.normalized;

        if(inputDir != Vector2.zero)
        {
            float rotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg +  cameraTransform.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref currentVelocity, smoothRotationTime);
        } 
      
        float targetSpeed = moveSpeed * inputDir.magnitude;

        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedVelocity, 0.1f);

        if (inputDir.magnitude > 0 )
        {
            GetComponent<Actions>().Run();
        }
        else
        {
            GetComponent<Actions>().Stay();
 
        }
 
        transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);
    }
}
