using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{
    public float rotatespeed;
    float rotateNum;

    void Awake()
    {
        rotateNum = rotatespeed * Time.deltaTime;
    }

    void Update()
    {
        transform.Rotate(new Vector3(rotateNum, rotateNum, 0), Space.World);
    }

    
}
