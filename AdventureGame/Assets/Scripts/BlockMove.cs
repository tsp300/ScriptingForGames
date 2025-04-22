using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    private float absoluteSpeed;
    private float speed;
    private Vector3 distance;
    bool lorr;
   
    private void Start()
    {
        absoluteSpeed = Mathf.Ceil(Random.Range(1,5));
        distance = transform.position;
        speed = -absoluteSpeed;
    }
    private void Update()
    {
        if (transform.position.x <= 15)
        {
            speed = absoluteSpeed;
        } else if (transform.position.x >= 20)
        {
            speed = -absoluteSpeed;
        }
        distance.x += speed *Time.deltaTime;
        transform.position = distance;
    }
}
