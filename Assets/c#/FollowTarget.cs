using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    //定义两个游戏物体
    public Transform player;

    private Vector3 offset;//偏移量
    private Camera camera;//摄像机
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.position;
        camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            camera.orthographicSize = 8f;
            //transform.position = player.position + offset;
            return;
        }
       
        transform.position = player.position + offset;//视野跟随
        //float distance = Vector3.Distance(player.position, player.position);
        //float size = distance * 0.5f;
        //camera.orthographicSize = size;
    }
}
