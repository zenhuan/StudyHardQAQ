using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L06_Script : MonoBehaviour
{
    //Mathf是unity自封裝的常用數學函數類
    //以下為常用函數

    private void Start()
    {
        //得到一個a到b點之間的數，當t=0時為a t=1時為b t=0~1之間相應比例的值
        //Mathf.Lerp(float a, float b, float t);

        //得到a與b之間較小的那個數值
        //Mathf.Min(float a , float b )

        //得到a與b之間較大的那個數值
        //Mathf.Max(float a , float b )

        //讓v保持在min與max之間 如果<min 則=min 如果>max則=max
        //Mathf.Clamp(float v , float min , float max)
    }
}
