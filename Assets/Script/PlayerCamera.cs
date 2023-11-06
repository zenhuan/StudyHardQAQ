using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //cinemachine���-�I��ʹ��
    //����Ҫ֪����ɫ���l?
    public GameObject player;

    //Ӌ�����C�c��ɫ֮�g�ľ��x��
    [HideInInspector]public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //���x�� =  ���wλ�� - �c������ľ��x
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        //
        transform.position = offset + player.transform.position;

    }

}
