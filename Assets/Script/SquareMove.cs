using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    //colider�ǌ������������w�e�ģ�������ײ��
    //trigger�Ƿǌ��ĵ�

    //rigidbody�����N�О�ģʽ
    //1.Dynamic-��ȫ���c����ģ�M-ex.������
    //2.Kinematic-���������Ƅӣ���Ҫ�ô��a׌���Ƅ�-ex.����Ƅ�
    //3.Static-��ȫ�����Ƅ�-ex.���ڡ�����
    //���Å���-gravity scale�������
    //Constraints-�i�����D
    //Material-���Ə����cĦ��

    //collision2d�¼�-enter2d(�������r�|�l) exit2d(���x�_�r�|�l) stay2d(��ײ�rÿ���|�l)

    // Start is called before the first frame update

    public SpriteRenderer sr;
    public SpriteRenderer sr2;
    public GameObject ground;
    public GameObject triiger;

    int layermask = 1<<6;

    void Start()
    {
        

       

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == triiger)
            sr2.color = new Color(Random.value, Random.value, Random.value);
    }




    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == ground)
        sr.color = new Color(Random.value, Random.value, Random.value);
        

    }
    */

    // Update is called once per frame
    void Update()
    {
        
    }
}
