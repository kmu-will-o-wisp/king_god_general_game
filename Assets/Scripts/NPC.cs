using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    Rigidbody rigid;
    public GameObject hidden;

    void Awake()
    {
        hidden = GameObject.FindWithTag("Hidden");
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //hidden.SetActive(false);
        //Debug.Log(hidden);
    }

    void OnMouseUp()
    {
        rigid.AddForce(transform.up * 150);
        hidden.SetActive(false);
    }
}
