using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{

    [SerializeField] float speed = 3.0f;

    private void Update()
    {
        //Vector3 direction = new Vector3(0, 0, -1);  
        //transform.position = transform.position + direction * speed * Time.deltaTime;

        transform.Translate(Vector3.back * speed * Time.deltaTime);
        
    }

 

}
