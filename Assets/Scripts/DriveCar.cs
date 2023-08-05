using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _frontWheelRB;
    [SerializeField] private Rigidbody2D _backWheelRB;
    [SerializeField] private Rigidbody2D _carRB;
    [SerializeField] private float _speed = 150f;
    [SerializeField] private float _rotationSpeed = 300f;

    private float _moveInput;

    private void Update() 
    {
        _moveInput = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        _frontWheelRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _backWheelRB.AddTorque(-_moveInput * _speed * Time.fixedDeltaTime);
        _carRB.AddTorque(_moveInput * _rotationSpeed * Time.fixedDeltaTime);
    }
}
