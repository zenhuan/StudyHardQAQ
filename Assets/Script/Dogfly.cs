using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogfly : MonoBehaviour  
{
    //ÿ�������һ������-׌һ��timer�����f�� ��timer=s �t����

    //���w�\��һ��Ҫ���ٶ�!
    public float spd = 1.0f;
    //���w�\�еİ돽
    public float radius = 4.0f;
    //ÿ������D��?
    public float turninterval = 1.0f;
    //Ӌ�r��
    float timer;
   //�o䛮�ǰ����
    Vector3 dir;
    //���x��ǰλ��
    Vector3 oPos;

    void Start()
    {
        //��ʼ���S�C���� (-0.5��ԭ���Ҫ׌����ƽ�����S�C�Ƅ� )
        dir = new Vector3(Random.value - 0.5f, Random.value - 0.5f , 0);


    }

    
    void Update()
    {
        //����\�����w? λ���D��-����* �ٶ�* �r�g
        transform.Translate(dir * spd * Time.deltaTime);
       //�r�g����
        timer += Time.deltaTime;
        //����r�g>�D������r�g
        if(timer > turninterval)
        {
            //�S�C�D��
            dir = new Vector3(Random.value - 0.5f, Random.value - 0.5f, 0);
            //Ӌ�r�w��
            timer = 0;
        }


        //���x=�������� ���x
        float dist = Vector3.Distance(oPos, transform.position);
        if(dist > radius)
        {
            dir = -dir;
        }

    }
}
