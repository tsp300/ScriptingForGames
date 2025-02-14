using UnityEngine;

public class Animat : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Handle();
    }

    private void Handle()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("DoubleJump");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
    }
}
