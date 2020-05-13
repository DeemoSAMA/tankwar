using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour
{

    public GameObject shellExplosionPrefab;//定义子弹爆炸特效
    public AudioClip shellExplosionAudio;//子弹爆炸的声音
    //触发子弹爆炸的函数
    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Instantiate(shellExplosionPrefab, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);//销毁子弹
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position, 1.0f);
        if (collider.tag == "tank")
        {
            collider.SendMessage("TakeDamage");
        }

        //GameObject.Destroy(shellExplosionPrefab);
    }


}
