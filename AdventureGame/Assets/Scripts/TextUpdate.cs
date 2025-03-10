using UnityEngine;
using TMPro;
using System.Globalization;
using System.Collections;

[RequireComponent(typeof(TextMeshProUGUI))]

public class TextUpdate : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public SimpleInt dataObj;

    private int i = 20;
    private RectTransform rectTrans;

    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        rectTrans = GetComponent<RectTransform>();
        UpdateWithIntData();
    }

    public void UpdateWithIntData()
    {
        textObj.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
        StartCoroutine(shaking());
    }

    private IEnumerator shaking()
    {
        rectTrans.rotation = Quaternion.Euler(0,0,i);
        yield return new WaitForSeconds(0.1f);
        rectTrans.rotation = Quaternion.Euler(0,0,-i);
        yield return new WaitForSeconds(0.1f);
        rectTrans.rotation = Quaternion.Euler(0, 0, 0);
        i *= -1;
    }
}
