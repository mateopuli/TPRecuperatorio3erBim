﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Silla")
        {
            Debug.Log("fadsf");
            transform.position = new Vector3(-15, 1.6f, 6.4f); 
        }
        if (col.gameObject.tag == "Death")
        {
            Debug.Log("fadsf");
            transform.position = new Vector3(-15, 1.6f, 6.4f);
        }
    }
}
