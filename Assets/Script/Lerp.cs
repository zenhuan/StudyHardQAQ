using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    Vector3 pos = new Vector3(10, 0, 0);
    bool islerping = true;
    void Start()
    {
        
    }

    void Update()
    {
        if(islerping)
        {
            //a�����c b�ǽK�c t�����gֵ
            transform.position = Vector3.Lerp(transform.position, pos, 0.005f);
            if (Vector3.Distance(pos, transform.position) < 0.1f)
            {
                transform.position = pos;
                islerping = false;
            }
        }

      
        
       

    }
}
