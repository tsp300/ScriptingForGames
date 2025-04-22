using UnityEngine;
using UnityEngine.Events;

public class AttachOnTrigger : MonoBehaviour
{
    public SimpleFloatData count;
    public UnityEvent uEvent;
    int  stop;
    public GameObject text;

    private void Start()
    {
        count.value = 0;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        transform.parent = other.transform;

        if (stop == 0)
        {
            stop++;
            uEvent.Invoke();
            
            if (text != null)
            {
                Destroy(text);
            }
        }
    }
}