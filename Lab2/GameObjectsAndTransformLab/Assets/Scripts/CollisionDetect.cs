using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) 
    {     
        Debug.Log("Collision detectected with " +  collision.gameObject.name);
    }
}
