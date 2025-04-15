using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class ParticleControl : MonoBehaviour
{
    private ParticleSystem particle;
    public int particInt = 10;


    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            particle.Emit(particInt);
        }
    }
}