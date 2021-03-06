﻿using UnityEngine;

public class JoystickBallController : MonoBehaviour
{
    public float speed = 1f;
    public Joystick joystick;
    public Rigidbody rb;

    void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}