using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //cinemachine插件-業界使用
    //首先要知道角色是誰?
    public GameObject player;

    //計算相機與角色之間的距離差
    [HideInInspector]public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //距離差 =  物體位置 - 與玩家相差的距離
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        //
        transform.position = offset + player.transform.position;

    }

}
