using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogfly : MonoBehaviour  
{
    //每幾秒鐘做一件事情-讓一個timer不斷遞增 當timer=s 則執行

    //物體運行一定要有速度!
    public float spd = 1.0f;
    //物體運行的半徑
    public float radius = 4.0f;
    //每幾秒鐘轉向?
    public float turninterval = 1.0f;
    //計時器
    float timer;
   //紀錄當前方向
    Vector3 dir;
    //定義當前位置
    Vector3 oPos;

    void Start()
    {
        //初始化隨機方向 (-0.5的原因為要讓他在平面上隨機移動 )
        dir = new Vector3(Random.value - 0.5f, Random.value - 0.5f , 0);


    }

    
    void Update()
    {
        //如何運行物體? 位置轉化-方向* 速度* 時間
        transform.Translate(dir * spd * Time.deltaTime);
       //時間增加
        timer += Time.deltaTime;
        //如果時間>轉向需求時間
        if(timer > turninterval)
        {
            //隨機轉向
            dir = new Vector3(Random.value - 0.5f, Random.value - 0.5f, 0);
            //計時歸零
            timer = 0;
        }


        //距離=三圍向量 距離
        float dist = Vector3.Distance(oPos, transform.position);
        if(dist > radius)
        {
            dir = -dir;
        }

    }
}
