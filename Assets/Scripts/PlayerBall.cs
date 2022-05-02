using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManagerLogic manager;
    bool isJump;
    Rigidbody rigid;
    AudioSource myAudio;

    void Awake() {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        myAudio = GetComponent<AudioSource>();

    }

    void Update() {
        if(Input.GetButtonDown("Jump") && !isJump){
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Item")
        {
            itemCount++;
            myAudio.Play();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Point")
        {

            if(itemCount == manager.totalItemCount)
            {
                SceneManager.LoadScene("Example1_0");
            }
            else
            {
                SceneManager.LoadScene("Example1_0");
            }
        }
    }
}

