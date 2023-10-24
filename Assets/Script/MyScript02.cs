using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MyScript02 : MonoBehaviour
{
    //列表
    public List<Point2D> points = new List<Point2D>();

    //scrpit被加載時 執行一次
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //類的構造函數
        //可以調用下面的 public Point2D() 或是 public Point2D(float xx , float yy)
        Point2D p1 = new Point2D(1.3f, 5.9f);
        Point2D p2 = new Point2D(1.7f, 6.0f);
        Point2D p3 = new Point2D(2.3f, 6.9f);

        //列表常用項目
        //將物體加入list中 Add(項目); 加入順序為最尾端
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        /*將物體從list中刪除 Remove(項目);
        //points.Remove();
        //將物體加入list中 Add(項目); 加入順序根據序號插入
        //points.Insert();
        print(points[2].x);
        //訪問
        類型 名稱 = 訪問列表[第幾個?].裡面的誰?
        */
        float point = points[2].x;

        //實際使用枚舉，是有點類似可以寫進代碼當中的註釋
        Direction dog = Direction.East;
        Direction cat = Direction.North;

        if (cat == dog)
        {
            //xxxx
        }

        //每個場景裡面的項目都是gameobject
        //每個gameobject都是由很多組件(compoment)組成的
        //ctrl+d gameobject可以實現類似複製+拖動的操作

        gameObject.SetActive(true);
        gameObject.AddComponent<BoxCollider2D>();
        //GameObject.Destroy(gameObject);


        /*for (int i = 0;  i < 22 ;  i=i+2 )
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = new Vector3(i, 0, 0);
        }
        */

        //先定義一個變量類型是SpriteRenderer 名稱sr 要get到這個組件(GetComponent)把值賦予給變量 <尖括號為獲取類型>
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;

        //vector3用法
        Vector3 v = new Vector3(1f, 1f, 1f);
        Vector3 n = new Vector3(6f, 6f, 6f);

        //計算兩個點使用的
       float dist = Vector3.Distance(v, n);
        print(dist);

        //管理gameobject的位置、旋轉、縮放
        //只寫一個transform就代表了當前物體(unity自定義的)
        //改變當成物體位置至n
        //transform.position = n;
        //相對於父物體的距離
        //transform.localPosition = new Vector3(3f, 3f, 3f);
        //相對於父物體改變當前物體大小
        //transform.localScale = n;

        //transform"類"常用的方法
        //移動x5
        transform.Translate(new Vector3(5, 0, 0));
        //獲取子物體信息
        transform.GetChild(2).GetComponent<SpriteRenderer>().color = Color.black;
        transform.GetChild(2).GetComponent<Transform>().localPosition = new Vector3(2f, 0, 0);
        transform.GetChild(2).GetComponent<Transform>().localScale = new Vector3(3f, 3f, 0);

       
    }

    float timer = 0;
  
  

    //每0.02秒運行1次
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > 1)
        {
            print("meowmew");
            timer = 0;
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            print("Quest");
        }

        if(Input.GetMouseButtonDown(0))
        {
            print("attack");
        }
    }

    //每禎進行1次
    private void FixedUpdate()
    {
        
    }

    /*
    大寫的(GameObject)為類
    小寫的(gameObject)為當前物體
    gameObject常用字段-> name tag layer transform

    gameObject常用方法
    1.setactive 啟用/不啟用物體->第53列
    2.AddComponent <引用組件名稱>(); ->第54列
    3.Destroy Gameobject.destroy(gameobject) 摧毀物體 ->第56列
    4.CreatePrimitive 創建物體
    */

    /*class component
    1. get component


     */





}

public class Point2D
{
    //類可以想像成工具，類裡的函數則是工具的功能
    //類是數據類型，可以像是變量一樣被使用 
    //定義語法 class 名稱 {變量與函數}

    public float x;
    public float y;

    public Point2D()
    {

    }

    public Point2D(float xx , float yy)
    {
        this.x = xx;
        this.y = yy;
    }
}

//枚舉是給"數字"命名的方式
//本質就是個可以訪問的列表，第一個為0...1..2 以此類推
public enum Direction
{
    East,
    West,
    North,
    South,
}
