using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharMove : MonoBehaviour
{
    public SimpleFloatData health;
    public SimpleFloatData xp;

    public float speed = 10f;
    public float jumpForce = 10f;
    public float gravity = 9.81f;
    public float fallingDegree = 5;
    private bool jjumping;

    private float yPos;


    private Transform ThisTransform;
    private CharacterController control;
    private Vector3 shmovement = Vector3.zero;


    private AudioSource audioSrc;


    void Start()
    {
        control = GetComponent<CharacterController>();
        ThisTransform = transform;
        audioSrc = GetComponent<AudioSource>();

        health.value = 1; // Temporary fix so that health 
        xp.value = 0;  // and xp don't save between testing
    }

   
    void FixedUpdate()
    {
        gravitate();
        ShmoveEm();
        ZLock();

        if (health.value <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void ShmoveEm()
    {
        shmovement.x = Input.GetAxis("Horizontal");
        shmovement *= (speed * Time.deltaTime);
        control.Move(shmovement);

        if (Input.GetButtonDown("Jump") && control.isGrounded)
        {
            if (yPos == 0f) { yPos = transform.position.y; }
            jjumping = true;
            audioSrc.Play();
        }

        if (jjumping == true)
        {
            shmovement.y = jumpForce * Time.deltaTime * gravity * fallingDegree * 0.5f;
            if (transform.position.y >= yPos + jumpForce) { 
                jjumping = false;
                yPos = 0f;
            }
        }
    }

    void gravitate()
    {
        if (!control.isGrounded && jjumping == false)
        {
            shmovement.y -= gravity * Time.deltaTime * fallingDegree;
        }
    }

    void ZLock()
    {
        var posit = ThisTransform.position;
        posit.z = 0f;
        ThisTransform.position = posit;
    }
}
