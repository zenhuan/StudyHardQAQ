using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class review : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    
    SpriteRenderer rd2;


    void Start()
    {
        //("�ӑB")��Ҫ���ӑB�����Ė|����һ����֪���ģ�����֪�� ����ֱ��ʹ�� ���.���� ���{��   ����:��ǰ���w��... transform.Translate
        //����ֱ���{�õģ��t����Ҫ��������

        //��unity���ҵ��ض�tag��gameobject��!
        circle1 = GameObject.FindGameObjectWithTag("Player");

        //һ̖��׃�{
        SpriteRenderer sr = circle1.GetComponent<SpriteRenderer>();
        sr.color = Color.blue;

        //�AȦ1�Ƅ�����һ��
        circle1.transform.Translate(new Vector3(0, -6, 0));


        //�AȦ2�Ƅ����AȦ3��λ��

        circle2.transform.position = circle3.transform.position;


        //�AȦ3���ɫ׃����AȦ1���ɫ

        SpriteRenderer sr2 = circle3.GetComponent<SpriteRenderer>();
        sr2.color = sr.color;


        //�}�uһ���AȦ1 λ���ڈAȦ1���Ϸ�

        GameObject clone = GameObject.Instantiate(circle1);
        clone.transform.Translate(new Vector3(0, 6, 0));


        rd2 = circle3.GetComponent<SpriteRenderer>();
      
    }

    
   

    // Update is called once per frame
    void Update()
    {
        //����E���o�r�h���AȦ1

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            GameObject.Destroy(circle1);
        }

        //����r�ĕr��׌�AȦ3����׃���S�C�ɫ

        if (Input.GetKey(KeyCode.R))
        {
            rd2.color = new Color(Random.value , Random.value , Random.value);

        }

       


    }
}
