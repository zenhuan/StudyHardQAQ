using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�L��ui�M����Ҫ���@��
using UnityEngine.UI;

public class L04_1029 : MonoBehaviour
{
    //��֪�R�c2-�������d
    //��ζ��ͬ�����������н��ܶ�����ͬ�����İ汾����Ҫ׫��һ��������ͬ��������ͬ�ĺ�������

    private void fun1 (int a , int b)
    {

    }

    private void fun1 (float a)
    {

    }

    //��֪�R-�ֶ����:�^�󲿷��Á��׃��unity�����е��@ʾ��ʽ
    //����1-[SerializeField]׌private׃��Ҳ�����������e�����@ʾ
    //����2-[HideInInspector]׌public׃�������������@ʾ
    //����3- [Range(0 ,10)] ��׃���������@ʾ�ķ�ʽ

    [SerializeField]private Rigidbody2D rb;
    [SerializeField] private Slider hpBar;
    //[SerializeField] private Sprite sp;
    public BoxCollider2D col;
    public float input_x;
    [HideInInspector]public bool input_y;
    [Range(0 ,10)]public int speed = 10;
    [Range(0, 30)] public float jumpforce = 1f;
    public bool isground;
    Animator anim;
    //��λ��
    Vector3 oscale;
    private string npcTag = "NPC";
    private string traptag = "Trap";
    private string goodtrap = "GoodTrap";
    
   

    float maxHp = 100;
    float currentHp = 100; 

    //animator�г��õ�api-(1)animator.SetBool(string name , bool value) �O��һ��bool��׃��
    //animator�г��õ�api-(2)animator.SetTrigger(string name , bool value) ����һ��trigger��׃��
    //amimator.play(string statename)

    void Start()
    {
        //�@ȡ�M���K���˴��a���d�ĈDƬ׃��ָ���DƬGetComponent<SpriteRenderer>().sprite = sp;
        anim = GetComponent<Animator>();
        //�D�Q�����춸����w�ı���
        oscale = transform.localScale;

        float x = transform.position.x;
        float range = Mathf.Clamp(x, 0, 10);

      

    }

    private void Update()
    {
        GetInput();
        Move();
        Jump();
        Ray();
        Animation();
        //Moverange();
    }

    private void Animation()
    {
        //(��unity��ԓtransitions�O����boolֵstring name , �l��)
        anim.SetBool("Moving", input_x != 0);

    }

    private void Moverange()
    {
        float x = transform.position.x;
        float range = Mathf.Clamp(x, 0, 10);
        rb.transform.position = new Vector3(range, transform.position.y, transform.position.z);
    }


    private void Move()
    {
        rb.velocity = new Vector2(input_x * speed, rb.velocity.y);
        if (input_x > 0)
        {
            transform.localScale = new Vector3(oscale.x, oscale.y, oscale.z);
        }
         else if (input_x < 0)
        {
            transform.localScale = new Vector3(-oscale.x, oscale.y, oscale.z);
        }
       
        //���ɾ���-���һ�����µĄӮ���!

    }

    public void Jump()
    {
        //����ڵذ��� �K�� �����հ��I
        if (isground && input_y )
        {
            //�o�脂�w��������һ���� 
            rb.AddForce(Vector2.up * 200 * jumpforce);
        }

    }

    private void Ray()
    {
        //ȡ�ô���ײ���ײ�λ�õ���Ϣ
        //Unity Bounds �߽�򣨰�Χ�У� https://blog.csdn.net/qq_37524903/article/details/113625126
        //�����S������ ��һ��origim ����λ���� col.bounds.center(�@ȡ�����c) ��ؓy�S�돽col.bounds.extents.y
        Vector3 origin = col.bounds.center + new Vector3(0, -col.bounds.extents.y);
        //�ذ�z�y- �侀(��ԭ�c, �l���°l�� , 0.1f , �ڵ�����layer)
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 0.1f, 1 << 3);
        Debug.DrawLine(origin,origin+ Vector3.down * 0.1f, Color.red , Time.deltaTime);
        //bool isground�O��hit�Л]�Йz�y������(��������colider)
        isground = hit.collider;
       
    }

    public void GetInput()
    {
        //GetAxisRaw�������ݔ��������ҵĕr�򷵻�(1,0)����(-1,0)
        input_x = Input.GetAxisRaw("Horizontal");
        input_y = Input.GetKeyDown(KeyCode.Space);
    }

    public void DamageSelf()
    {
        currentHp -= 20;
        hpBar.value = currentHp / maxHp;
    }

    public void HealeSelf()
    {
        currentHp += 20;
        hpBar.value = currentHp / maxHp;
    }

    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(npcTag))
        {
            NPC npc = collision.GetComponent<NPC>();
            {
                npc.textBubbleAnim.SetBool("Appear", true); 
            }
        }
        if (collision.CompareTag(traptag) && maxHp > 0)
        {
            DamageSelf();

        }
        if (collision.CompareTag(goodtrap) && currentHp < 100)
        {
            HealeSelf();

        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(npcTag))
        {
            NPC npc = collision.GetComponent<NPC>();
            {
                npc.textBubbleAnim.SetBool("Appear", false);
            }
        }
    }

  
    

}


