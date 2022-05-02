using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class animationControl : MonoBehaviour
{
    public float moveSpeed = 5.0f; 
    float horizontal, vertical;

    public float jumpPower;
    public int itemCount;
    bool isJump;
    Rigidbody rigid;

    public Animator animator; 

    private void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {

        Move();
    }


    void Move()
    {


        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0)
        {
            animator.SetBool("walk", true);
        }
        else if (vertical != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        rigid.AddForce(new Vector3(horizontal, 0, vertical), ForceMode.Impulse);
        //Vector3 dir = horizontal * Vector3.right; 
        //this.transform.Translate(dir * moveSpeed * Time.deltaTime); 
    }
}