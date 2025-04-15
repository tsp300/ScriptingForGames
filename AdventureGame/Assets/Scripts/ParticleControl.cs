using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class ParticleControl : MonoBehaviour
{
    private ParticleSystem particle;

    public int particInt0 = 10;
    public int particInt1 = 20;
    public int particInt2 = 30;
    public float particDelay = 0.5f;

    private void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            StartCoroutine(EmitParticles());
        }
    }

    private IEnumerator EmitParticles()
    {
        particle.Emit(particInt0);
        yield return new WaitForSeconds(particDelay);

        particle.Emit(particInt1);
        yield return new WaitForSeconds(particDelay);

        particle.Emit(particInt2);
    }
}