using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    Rigidbody Spaceship;

    public JoystickControl joystick;
    public static bool isEngineStart = false;
    private bool isUpward = false, isDownward = false;

    private float forwardSpeed = 700.0f;
    private float tiltAmountForward = 0;
    private float tiltVelocityForward;

    private float yRotation;
    private float currentYRotation;
    private float rotateAmountByKeys = 2.5f;
    private float rotationVelocity;
    private bool isLeft = false, isRight = false;
    private Vector3 velocityToSmoothDampToZero;
    private float sideMovementAmount = 300.0f;
    private float tiltAmountSideways;
    private float tiltAmountVelocity;


    void Start()
    {
        Spaceship = GetComponent<Rigidbody>();
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        // float currentX = tiltAmountForward;
        // float currentY = currentYRotation;
        // float currentZ = tiltAmountSideways;

        if(isEngineStart){
            moveUpandDown();
            moveForwardandBackward();
            rotateY();
            clampingSpeedValue();
            Spaceship.rotation = Quaternion.Euler(new Vector3(tiltAmountForward, currentYRotation, tiltAmountSideways));
        }
        //Spaceship.rotation = Quaternion.Euler(new Vector3(tiltAmountForward, currentYRotation, tiltAmountSideways));
    }

    void moveUpandDown()
    {
        if(isUpward){
            Spaceship.AddRelativeForce(Vector3.up * 600.0f);
        }else if(isDownward){
            Spaceship.AddRelativeForce(Vector3.up * -300.0f);
        }else if(!isUpward && !isDownward){
            Spaceship.AddRelativeForce(Vector3.up * 98.0f);
        }
    }

    public void moveUp(bool up){
        isUpward = up;
    }

    public void moveDown(bool down){
        isDownward = down;
    }

    void moveForwardandBackward()
    {
        if(joystick.InputDir.y>0.2){
            Spaceship.AddRelativeForce(Vector3.forward * joystick.InputDir.y * forwardSpeed);
            tiltAmountForward = Mathf.SmoothDamp(tiltAmountForward, 20 * joystick.InputDir.y, ref tiltVelocityForward, 0.1f);
        }
        if(joystick.InputDir.y<0.2){
            Spaceship.AddRelativeForce(Vector3.back * joystick.InputDir.y * -forwardSpeed);
            tiltAmountForward = Mathf.SmoothDamp(tiltAmountForward, 20 * joystick.InputDir.y, ref tiltVelocityForward, 0.1f);
        }
        if(joystick.InputDir.x>0.2){
            Spaceship.AddRelativeForce(Vector3.right * joystick.InputDir.x * sideMovementAmount);
            tiltAmountSideways = Mathf.SmoothDamp(tiltAmountSideways, -20 * joystick.InputDir.x, ref tiltAmountVelocity, 0.1f);
        }
        if(joystick.InputDir.x<0.2){
            Spaceship.AddRelativeForce(Vector3.left * joystick.InputDir.x * -sideMovementAmount);
            tiltAmountSideways = Mathf.SmoothDamp(tiltAmountSideways, -20 * joystick.InputDir.x, ref tiltAmountVelocity, 0.1f);
        }
    }

    void rotateY()
    {
        if(isLeft){
            yRotation -= rotateAmountByKeys;
        }
        if(isRight){
            yRotation += rotateAmountByKeys;
        }

        currentYRotation = Mathf.SmoothDamp(currentYRotation, yRotation, ref rotationVelocity, 0.25f);
    }

    public void rotateLeft(bool left){
        isLeft = left;
    }

    public void rotateRight(bool right){
        isRight = right;
    }

    void clampingSpeedValue()
    {
        if(Mathf.Abs(joystick.InputDir.y) > 0.2f && Mathf.Abs(joystick.InputDir.x) > 0.2f){
            Spaceship.velocity = Vector3.ClampMagnitude(Spaceship.velocity, Mathf.Lerp(Spaceship.velocity.magnitude, 200.0f, Time.deltaTime * 5f));
        }
        if(Mathf.Abs(joystick.InputDir.y) > 0.2f && Mathf.Abs(joystick.InputDir.x) < 0.2f){
            Spaceship.velocity = Vector3.ClampMagnitude(Spaceship.velocity, Mathf.Lerp(Spaceship.velocity.magnitude, 200.0f, Time.deltaTime * 5f));
        }
        if(Mathf.Abs(joystick.InputDir.y) < 0.2f && Mathf.Abs(joystick.InputDir.x) > 0.2f){
            Spaceship.velocity = Vector3.ClampMagnitude(Spaceship.velocity, Mathf.Lerp(Spaceship.velocity.magnitude, 100.0f, Time.deltaTime * 5f));
        }
        if(Mathf.Abs(joystick.InputDir.y) < 0.2f && Mathf.Abs(joystick.InputDir.x) < 0.2f){
            Spaceship.velocity = Vector3.SmoothDamp(Spaceship.velocity, Vector3.zero, ref velocityToSmoothDampToZero, 0.95f);
        }
    }
}
