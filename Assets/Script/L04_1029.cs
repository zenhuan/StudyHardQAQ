using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//訪問ui組件需要寫這個
using UnityEngine.UI;

public class L04_1029 : MonoBehaviour
{
    //新知識點2-函數重載
    //意味著同個參數可以有接受多個不同參數的版本，需要撰寫一個名字相同，參數不同的函數如下

    private void fun1 (int a , int b)
    {

    }

    private void fun1 (float a)
    {

    }

    //新知識-字段修飾符:絕大部分用來改變在unity引擎中的顯示方式
    //常用1-[SerializeField]讓private變量也可以在引擎裡面中顯示
    //常用2-[HideInInspector]讓public變量不在引擎中顯示
    //常用3- [Range(0 ,10)] 改變在引擎中顯示的方式

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
    //聲明位子
    Vector3 oscale;
    private string npcTag = "NPC";
    private string traptag = "Trap";
    private string goodtrap = "GoodTrap";
    
   

    float maxHp = 100;
    float currentHp = 100; 

    //animator中常用的api-(1)animator.SetBool(string name , bool value) 設定一個bool的變量
    //animator中常用的api-(2)animator.SetTrigger(string name , bool value) 激活一個trigger的變量
    //amimator.play(string statename)

    void Start()
    {
        //獲取組件並將此代碼掛載的圖片變成指定圖片GetComponent<SpriteRenderer>().sprite = sp;
        anim = GetComponent<Animator>();
        //轉換於相對於父物體的比例
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
        //(在unity中該transitions設定的bool值string name , 條件)
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
       
        //自由練習-添加一個蹲下的動畫吧!

    }

    public void Jump()
    {
        //玩家在地板上 並且 按壓空白鍵
        if (isground && input_y )
        {
            //給予剛體往上增加一個力 
            rb.AddForce(Vector2.up * 200 * jumpforce);
        }

    }

    private void Ray()
    {
        //取得此碰撞器底部位置的信息
        //Unity Bounds 边界框（包围盒） https://blog.csdn.net/qq_37524903/article/details/113625126
        //在三維向量中 有一個origim 它的位置是 col.bounds.center(獲取中心點) 的負y軸半徑col.bounds.extents.y
        Vector3 origin = col.bounds.center + new Vector3(0, -col.bounds.extents.y);
        //地板檢測- 射線(從原點, 發向下發射 , 0.1f , 在第三個layer)
        RaycastHit2D hit = Physics2D.Raycast(origin, Vector2.down, 0.1f, 1 << 3);
        Debug.DrawLine(origin,origin+ Vector3.down * 0.1f, Color.red , Time.deltaTime);
        //bool isground設限hit有沒有檢測到地面(或是任意colider)
        isground = hit.collider;
       
    }

    public void GetInput()
    {
        //GetAxisRaw為在玩家輸入左或是右的時候返回(1,0)或是(-1,0)
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


