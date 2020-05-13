using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{

    private Transform firePosition;//发射位置
    public GameObject shellPrefab;//子弹预置体
    public KeyCode fireKey = KeyCode.Space;//子弹发射按钮
    public float Speed = 5f;

    public float shellSpeed = 10f;
    public AudioClip shotAudio;//发射子弹的声音
    //private Rigidbody shell;
    // Use this for initialization
    void Start()
    {
        firePosition = transform.Find("FirePosition");//子弹发射的位置

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio, transform.position, 1.0f);
            GameObject go = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation) as GameObject;//实例化子弹
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
            //GameObject del = GameObject.Find("shellPrefab");
            //Destroy(del);
        }
    }
    void FixedUpdate()
    {

    }
}
