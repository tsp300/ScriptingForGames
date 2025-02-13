using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float speed = 10f;
    private Transform ThisTransform;
    private CharacterController control;
    private Vector3 shmovement = Vector3.zero;


    void Start()
    {
        control = GetComponent<CharacterController>();
        ThisTransform = transform;
    }

   
    void FixedUpdate()
    {
        ShmoveEm();
        ZLock();
    }

    void ShmoveEm()
    {
        shmovement.x = Input.GetAxis("Horizontal");
        shmovement *= (speed * Time.deltaTime);
        control.Move(shmovement);
    }

    void ZLock()
    {
        var posit = ThisTransform.position;
        posit.z = 0f;
        ThisTransform.position = posit;
    }
}
