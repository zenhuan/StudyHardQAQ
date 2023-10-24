using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MyScript02 : MonoBehaviour
{
    //�б�
    public List<Point2D> points = new List<Point2D>();

    //scrpit�����d�r ����һ��
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //Ę��캯��
        //�����{������� public Point2D() ���� public Point2D(float xx , float yy)
        Point2D p1 = new Point2D(1.3f, 5.9f);
        Point2D p2 = new Point2D(1.7f, 6.0f);
        Point2D p3 = new Point2D(2.3f, 6.9f);

        //�б����Ŀ
        //�����w����list�� Add(�Ŀ); ����������β��
        points.Add(p1);
        points.Add(p2);
        points.Add(p3);
        /*�����w��list�Єh�� Remove(�Ŀ);
        //points.Remove();
        //�����w����list�� Add(�Ŀ); ������������̖����
        //points.Insert();
        print(points[2].x);
        //�L��
        ��� ���Q = �L���б�[�ڎׂ�?].�e����l?
        */
        float point = points[2].x;

        //���Hʹ��ö�e�������c��ƿ��Ԍ��M���a���е��]�
        Direction dog = Direction.East;
        Direction cat = Direction.North;

        if (cat == dog)
        {
            //xxxx
        }

        //ÿ�������e����Ŀ����gameobject
        //ÿ��gameobject�����ɺܶ�M��(compoment)�M�ɵ�
        //ctrl+d gameobject���Ԍ��F����}�u+�τӵĲ���

        gameObject.SetActive(true);
        gameObject.AddComponent<BoxCollider2D>();
        //GameObject.Destroy(gameObject);


        /*for (int i = 0;  i < 22 ;  i=i+2 )
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.transform.position = new Vector3(i, 0, 0);
        }
        */

        //�ȶ��xһ��׃�������SpriteRenderer ���Qsr Ҫget���@���M��(GetComponent)��ֵ�x��o׃�� <����̖��@ȡ���>
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;

        //vector3�÷�
        Vector3 v = new Vector3(1f, 1f, 1f);
        Vector3 n = new Vector3(6f, 6f, 6f);

        //Ӌ��ɂ��cʹ�õ�
       float dist = Vector3.Distance(v, n);
        print(dist);

        //����gameobject��λ�á����D���s��
        //ֻ��һ��transform�ʹ����ˮ�ǰ���w(unity�Զ��x��)
        //��׃�������wλ����n
        //transform.position = n;
        //����춸����w�ľ��x
        //transform.localPosition = new Vector3(3f, 3f, 3f);
        //����춸����w��׃��ǰ���w��С
        //transform.localScale = n;

        //transform"�"���õķ���
        //�Ƅ�x5
        transform.Translate(new Vector3(5, 0, 0));
        //�@ȡ�����w��Ϣ
        transform.GetChild(2).GetComponent<SpriteRenderer>().color = Color.black;
        transform.GetChild(2).GetComponent<Transform>().localPosition = new Vector3(2f, 0, 0);
        transform.GetChild(2).GetComponent<Transform>().localScale = new Vector3(3f, 3f, 0);

       
    }

    float timer = 0;
  
  

    //ÿ0.02���\��1��
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

    //ÿ���M��1��
    private void FixedUpdate()
    {
        
    }

    /*
    �󌑵�(GameObject)���
    С����(gameObject)�鮔ǰ���w
    gameObject�����ֶ�-> name tag layer transform

    gameObject���÷���
    1.setactive ����/���������w->��53��
    2.AddComponent <���ýM�����Q>(); ->��54��
    3.Destroy Gameobject.destroy(gameobject) �ݚ����w ->��56��
    4.CreatePrimitive �������w
    */

    /*class component
    1. get component


     */





}

public class Point2D
{
    //�������ɹ��ߣ���e�ĺ����t�ǹ��ߵĹ���
    //��ǔ�����ͣ���������׃��һ�ӱ�ʹ�� 
    //���x�Z�� class ���Q {׃���c����}

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

//ö�e�ǽo"����"�����ķ�ʽ
//���|���ǂ������L�����б���һ����0...1..2 �Դ����
public enum Direction
{
    East,
    West,
    North,
    South,
}
