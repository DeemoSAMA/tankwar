using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankdestroy : MonoBehaviour
{

    public GameObject tankExplosionPrefab;
    // Use this for initialization
    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Instantiate(tankExplosionPrefab, transform.position, transform.rotation);
        //GameObject.Destroy(this.gameObject);//销毁子弹
        //GameObject.Destroy(shellExplosionPrefab);
    }
}
