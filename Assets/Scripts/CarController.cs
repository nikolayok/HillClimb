using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float _speed = -1500;
    [SerializeField] private WheelJoint2D _backWheelJoint2D;
    private JointMotor2D _jointMotor2DMoveForward;
    private JointMotor2D _jointMotor2DMoveBackward;
    private float _rotationSpeed = 500f;

    private void Start() 
    {
        _jointMotor2DMoveForward = new JointMotor2D();
        _jointMotor2DMoveBackward = new JointMotor2D();
        _jointMotor2DMoveForward.maxMotorTorque = 10000;
        _jointMotor2DMoveBackward.maxMotorTorque = 10000;
        _jointMotor2DMoveForward.motorSpeed = _speed;
        _jointMotor2DMoveBackward.motorSpeed = - _speed;
        StopUseMotor();
    }

    public void MoveForward()
    {
        _backWheelJoint2D.motor = _jointMotor2DMoveForward;
        _backWheelJoint2D.useMotor = true;
    }

    public void MoveBackward()
    {
        _backWheelJoint2D.motor = _jointMotor2DMoveBackward;
        _backWheelJoint2D.useMotor = true;
    }

    public void StopUseMotor()
    {
        _backWheelJoint2D.useMotor = false;
    }

    private void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            MoveForward();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            StopUseMotor();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveBackward();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            StopUseMotor();
        }
    }

    private void Update()
    {
        //_movement = - Input.GetAxisRaw("Vertical") * _speed;
        GetInput();
    }

    private void FixedUpdate() 
    {
        // _backWheelJoint2D.motor.speed = _movement;
    }
}
