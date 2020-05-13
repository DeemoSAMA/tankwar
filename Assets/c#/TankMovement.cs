using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    //
    public float Speed = 5f;//起始速度
    public float turnSpeed = 20f;//旋转速度
    public float number = 1;//玩家的编号
    //
    private Rigidbody rigidbody;//刚体
    public AudioClip MoveAudio;
    public AudioClip idleAudio;
    private AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();//
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.anyKeyDown)
        {
            AudioSource.PlayClipAtPoint(MoveAudio, transform.position, 1.0f);
        }*/
    }

    void FixedUpdate()
    {
        //if (number == 1) 
        {
           
            float v = Input.GetAxis("Vertical" + number);
            rigidbody.velocity = transform.forward * v * Speed;
            float h = Input.GetAxis("Horizontal" + number);
            //Quaternion turn = Quaternion.Euler(0, turnSpeed * Time.deltaTime * h, 0);
            //rigidbody.MoveRotation(rigidbody.rotation * turn);
            rigidbody.angularVelocity = transform.up * h * turnSpeed;
            if(Mathf.Abs(h)>0.1f||Mathf.Abs(v)>0.1f)
            {
                audioSource.clip = MoveAudio;
                if(audioSource.isPlaying==false)
                {
                    audioSource.Play();
                }
            }
            else
            {
                audioSource.clip = idleAudio;
                if(audioSource.isPlaying==false)
                {
                    audioSource.Play();
                }
            }
        }
        /* else{
             float v = Input.GetAxis("Vertical1");
             rigidbody.velocity = transform.forward * v * Speed;
             float h = Input.GetAxis("Horizontal1");
             //Quaternion turn = Quaternion.Euler(0, turnSpeed * Time.deltaTime * h, 0);
             //rigidbody.MoveRotation(rigidbody.rotation * turn);
             rigidbody.angularVelocity = transform.up * h * turnSpeed;
         }*/
    }
}
