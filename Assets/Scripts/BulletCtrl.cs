﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    //총알의 파괴력
    public int damage = 20;

    //총알의 발사 속도ㄴ
    public float speed = 1000.0f;
    
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }
}
