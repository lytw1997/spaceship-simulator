using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public EnvironmentControl environmentTouchField;
    public Transform mainCamera;

    private float cameraAngle;
    private float cameraRotateSpeed = 0.2f;
    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        cameraAngle += environmentTouchField.TouchDist.x * cameraRotateSpeed;
        mainCamera.position = transform.position + Quaternion.AngleAxis(cameraAngle, Vector3.up) * new Vector3(0, 60, -70);
        mainCamera.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 50f -mainCamera.transform.position, Vector3.up);
        //Debug.Log(mainCamera.rotation);
    }
}
