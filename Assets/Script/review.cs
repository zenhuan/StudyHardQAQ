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
        //("動態")需要被動態創建的東西是一定被知道的，是已知的 可以直接使用 類名.函數 名調用   例如:當前物體的... transform.Translate
        //可以直接調用的，則不需要創建實例

        //在unity中找到特定tag的gameobject吧!
        circle1 = GameObject.FindGameObjectWithTag("Player");

        //一號球變藍
        SpriteRenderer sr = circle1.GetComponent<SpriteRenderer>();
        sr.color = Color.blue;

        //圓圈1移動下面一格
        circle1.transform.Translate(new Vector3(0, -6, 0));


        //圓圈2移動至圓圈3的位置

        circle2.transform.position = circle3.transform.position;


        //圓圈3的顏色變更為圓圈1的顏色

        SpriteRenderer sr2 = circle3.GetComponent<SpriteRenderer>();
        sr2.color = sr.color;


        //複製一個圓圈1 位置在圓圈1的上方

        GameObject clone = GameObject.Instantiate(circle1);
        clone.transform.Translate(new Vector3(0, 6, 0));


        rd2 = circle3.GetComponent<SpriteRenderer>();
      
    }

    
   

    // Update is called once per frame
    void Update()
    {
        //按下E按鈕時刪除圓圈1

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            GameObject.Destroy(circle1);
        }

        //按下r的時候讓圓圈3不斷變為隨機顏色

        if (Input.GetKey(KeyCode.R))
        {
            rd2.color = new Color(Random.value , Random.value , Random.value);

        }

       


    }
}
