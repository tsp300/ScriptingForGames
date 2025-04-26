using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBrrr : MonoBehaviour
{
    float i = 0.3f;
    private Vector3 pos;
    

    public void shake()
    {
        StartCoroutine(shaking());
    }

    private IEnumerator shaking()
    {
        pos = transform.position;

        pos.x += i;             // position changing shenanigans
        pos.y += i;
        transform.position = pos;

        yield return new WaitForSeconds(0.05f);

        pos = transform.position;
        pos.x -= i * 2;          // position changing shenanigans again
        pos.y -= i * 2;
        transform.position = pos;

        yield return new WaitForSeconds(0.05f);

        pos = transform.position;
        pos.x += i;              // position changing back
        pos.y += i;
        transform.position = pos;
        i *= -1;
    }
}
