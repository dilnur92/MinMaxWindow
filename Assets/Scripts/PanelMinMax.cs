using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelMinMax : MonoBehaviour
{
    public RectTransform wrapperTransform;
    float wrapperOriginalBottomValue = 0f;
    float wrapperOriginalTopValue = 0f;

    //Bring the  Canvas right to the middle

    public void Maximize()
    {
        //get the original offset values(top, bottom)
        wrapperOriginalTopValue = Mathf.Abs(wrapperTransform.offsetMax.y);
        wrapperOriginalBottomValue = Mathf.Abs(wrapperTransform.offsetMin.y);
        Debug.Log("bottom:" + wrapperOriginalBottomValue);
        Debug.Log("top: " + wrapperOriginalTopValue);
        //center the wrapper panel
        wrapperTransform.SetBottom(0f);
        wrapperTransform.SetTop(0f);
    }

    public void Minimize()
    {
        //set original offset values
        wrapperTransform.SetBottom(wrapperOriginalBottomValue);
        wrapperTransform.SetTop(wrapperOriginalTopValue);
    }
}
