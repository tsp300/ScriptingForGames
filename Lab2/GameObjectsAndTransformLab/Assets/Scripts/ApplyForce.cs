using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * -25000);
    }
}