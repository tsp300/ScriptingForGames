using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BananaDoor : MonoBehaviour
{
    public SimpleFloatData data;
    private Animator animator;
    private BoxCollider coll;
    
    public int gap = 3; //int for how close to the fire the player has to be
    private float pos;

    public GameObject player;
    public GameObject[] bananas;
    public UnityEvent textChange;

    private void Start()
    {
        animator = GetComponent<Animator>();
        pos = transform.position.x;
        coll = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if (data.value >= bananas.Length && player.transform.position.x < pos + gap && player.transform.position.x > pos - gap)
        {
            
            animator.SetTrigger("Key");
            data.value -= bananas.Length;
            coll.enabled = false;
            textChange.Invoke();

            for (int i = 0; i < bananas.Length; i++)
            {
                bananas[i].GetComponent<BoxCollider>().enabled = false;
                bananas[i].AddComponent<Rigidbody>();
            }
        }
    }
}
