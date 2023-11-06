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

        //Mathf.Lerp(float a, float b, float t); ���Բ�ֵ ȡa�cb���g��t�� ���a=0 b=10 t=0.7 ���Nȡ���Ĕ���=7
        //Mathf.Min(1.5f (a), 9.9f (b));  ȡa�cb֮�g С���ǂ����������.Max�tȡ��Ĕ�
       // Mathf.Clamp(float v, float min, float max); ������v�O����min�cmax֮�g ���<min�t=MinAttribute maxͬ��>
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
