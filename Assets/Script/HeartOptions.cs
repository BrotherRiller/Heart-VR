using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartOptions : MonoBehaviour
{
    [SerializeField] float scaleValue = 0.01f;

    private Vector3 defaultScale;

    private void Start()
    {
        defaultScale = transform.localScale;
    }

    public void GetBigger()
    {
        if(transform.localScale.y >= 0.3f)
        {
            return;
        }

        transform.localScale += new Vector3(scaleValue, scaleValue, scaleValue);
    }

    public void GetSmaller()
    {
        if (transform.localScale.y <= 0.05f)
        {
            return;
        }

        transform.localScale -= new Vector3(scaleValue, scaleValue, scaleValue);
    }

    public void defaultSize()
    {

        transform.localScale = defaultScale;
    }
}
