using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    


    void Start()
    {
        //從gameobject類中 "生成物體" "生成物體sphere"
       // GameObject.CreatePrimitive(PrimitiveType.Sphere);

        //c#基礎概念-通常必須要聲明一個變量後 才能去調用以及使用他

        //題目-將方塊顏色更改為紅色
        //先定義一個變量類型是SpriteRenderer 名稱sr 要get到這個組件(GetComponent)把值賦予給變量 <尖括號為類型>
        // get到這個SpriteRenderer組件 把值賦給變量
        //在自身的物體上，去獲取一個為  SpriteRenderer 類型的 Component 並且把這個值給到左邊 "sr"的變量裡面
        //為什麼可以這樣做? 因為 左邊的類型是 SpriteRenderer 右邊的也是 SpriteRenderer 他們是可以賦值的
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        //sr目前代表了SpriteRenderer組件
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



        //插入點的字不見 按一下ins
        transform.Translate(new Vector3(input.x, input.y, 0)* speed * Time.deltaTime);
        transform.localScale = new Vector3(1+scale.x, 1+scale.y, 0); 
        
    }

    //大寫的gameobject- 可以理解為從類裡面訪問
    //小寫的gameobject- 可以理解為從當前物體(代碼綁定的物品)
    

}
