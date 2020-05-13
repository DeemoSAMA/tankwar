using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class tankhealth : MonoBehaviour
{

    public int hp = 100;//坦克初始血量
    public GameObject tankExplosionPrefab;
    public AudioClip tankExplosionAudio;//坦克爆炸的音效
    public Slider hpSlider; // 血条

    //坦克的伤害判定
    
    void TakeDamage()
    {
        if (hp <= 0)
        {
            return;
        }
        hp -= Random.Range(20, 30);
        hpSlider.value = (float)hp; // 设置 Slider 血条 的值
        if (hp <= 0)//受到伤害之后 血量为零 控制死亡效果
        {
            AudioSource.PlayClipAtPoint(tankExplosionAudio, transform.position, 1.0f);
            GameObject.Instantiate(tankExplosionPrefab, transform.position + Vector3.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
            //Slider.Destroy(this.hpSlider);
            hpSlider.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
