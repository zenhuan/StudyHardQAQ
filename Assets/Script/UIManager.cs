using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private string strAppear = "Appear";
    public GameObject uiPanel;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = uiPanel.GetComponent<Animator>();

        //Mathf.Lerp(float a, float b, float t); 線性插值 取a與b中間的t數 如果a=0 b=10 t=0.7 那麼取出的數字=7
        //Mathf.Min(1.5f (a), 9.9f (b));  取a與b之間 小的那個數，如果為.Max則取大的數
       // Mathf.Clamp(float v, float min, float max); 將數字v設定為min與max之間 如果<min則=MinAttribute max同理>
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            print("esc");
            ButtonClose(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            print("esc");
            ButtonClose(true);
        }

    }

    public void ButtonClose(bool isActive)
    {
        anim.SetBool( strAppear, isActive);
    }
}
