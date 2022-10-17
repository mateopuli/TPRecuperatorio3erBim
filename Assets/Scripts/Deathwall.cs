using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathwall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Silla")
        {
            transform.position = new Vector3(-15.13f, 1.63f, 6.4f);
        }
        if (col.gameObject.tag == "Death")
        {
            transform.position = new Vector3(-15.13f, 1.63f, 6.4f);
        }
    }
}
