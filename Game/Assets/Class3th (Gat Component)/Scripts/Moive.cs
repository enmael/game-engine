using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moive : MonoBehaviour
{

    void Start()
    {
        
    }

    public void OnMove(Vector3 direction)
    {

        transform.position = transform.position + direction;
        
    }


}

