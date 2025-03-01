using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public SimpleFloatData health;
    public SimpleFloatData xp;

    public float speed = 10f;
    public float jumpForce = 10f;
    public float gravity = 9.81f;

    private Transform ThisTransform;
    private CharacterController control;
    private Vector3 shmovement = Vector3.zero;


    void Start()
    {
        control = GetComponent<CharacterController>();
        ThisTransform = transform;
    }

   
    void Update()
    {
        gravitate();
        ShmoveEm();
        ZLock();
    }

    void ShmoveEm()
    {
        shmovement.x = Input.GetAxis("Horizontal");
        shmovement *= (speed * Time.deltaTime);
        control.Move(shmovement);

        if (Input.GetButtonDown("Jump") && control.isGrounded)
        {
            shmovement.y = Mathf.Sqrt(jumpForce * 2f * gravity);
        }
    }

    void gravitate()
    {
        if (!control.isGrounded)
        {
            shmovement.y -= gravity * Time.deltaTime * 15;
        }
    }

    void ZLock()
    {
        var posit = ThisTransform.position;
        posit.z = 0f;
        ThisTransform.position = posit;
    }
}
