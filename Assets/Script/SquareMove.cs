using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    //colider是實心且有物理體積的，會被碰撞的
    //trigger是非實心的

    //rigidbody的三種行為模式
    //1.Dynamic-完全參與物理模擬-ex.掉落物
    //2.Kinematic-不會主動移動，需要用代碼讓他移動-ex.玩家移動
    //3.Static-完全不會移動-ex.牆壁、地面
    //常用參數-gravity scale物件重力
    //Constraints-鎖定旋轉
    //Material-控制彈力與摩擦

    //collision2d事件-enter2d(剛碰到時觸發) exit2d(剛離開時觸發) stay2d(碰撞時每偵觸發)

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
