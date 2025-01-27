using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        var x = Mathf.PingPong(Time.time * 6, 5);
        var p = new Vector3(x, 0, 0);
        transform.position = p;

        transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
    }
}
