using UnityEngine;
using UnityEngine.Events;

public class Blam : MonoBehaviour
{
    public UnityEvent triggerEv;

    private void OnTriggerEnter(Collider other)
    {
        triggerEv.Invoke();
        Debug.Log("Object got touched!");
    }
}
