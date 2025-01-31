using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float BounceForce = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * BounceForce, ForceMode.Impulse);
    }
}
