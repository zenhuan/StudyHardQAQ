using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    


    void Start()
    {
        //��gameobject��� "�������w" "�������wsphere"
       // GameObject.CreatePrimitive(PrimitiveType.Sphere);

        //c#���A����-ͨ�����Ҫ��һ��׃���� ����ȥ�{���Լ�ʹ����

        //�}Ŀ-�����K�ɫ���Ğ�tɫ
        //�ȶ��xһ��׃�������SpriteRenderer ���Qsr Ҫget���@���M��(GetComponent)��ֵ�x��o׃�� <����̖�����>
        // get���@��SpriteRenderer�M�� ��ֵ�x�o׃��
        //����������w�ϣ�ȥ�@ȡһ����  SpriteRenderer ��͵� Component �K�Ұ��@��ֵ�o����߅ "sr"��׃���e��
        //��ʲ�N�����@����? ��� ��߅������� SpriteRenderer ��߅��Ҳ�� SpriteRenderer �����ǿ����xֵ��
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        //srĿǰ������SpriteRenderer�M��
        sr.color = Color.red;



        /*
        for (int i = 0; i<50; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = new Vector3(i + 1, 0, 0);
        }
        */

    }

    public float exp = 0.01f;
    public float speed = 1;
    Vector2 input;
    Vector2 scale;
     

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            input.y = 1;
            input.x = 0;
          
        }
        else if (Input.GetKey(KeyCode.S))
        {
            input.y = -1;
            input.x = 0;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            input.x = -1;
            input.y = 0;
            scale.x += exp;
            scale.y += exp;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            input.x = 1;
            input.y = 0;
            scale.x += exp;
            scale.y += exp;
        }
        else
        {
            input.x = 0;
            input.y = 0;
            scale.x = 0;
            scale.y = 0;
        }



        //�����c���ֲ�Ҋ ��һ��ins
        transform.Translate(new Vector3(input.x, input.y, 0)* speed * Time.deltaTime);
        transform.localScale = new Vector3(1+scale.x, 1+scale.y, 0); 
        
    }

    //�󌑵�gameobject- �����������e���L��
    //С����gameobject- ��������Į�ǰ���w(���a��������Ʒ)
    

}
