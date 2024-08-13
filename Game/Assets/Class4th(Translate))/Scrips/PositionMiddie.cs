using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMiddie : MonoBehaviour
{
    [SerializeField] Transform[] spawners;
    [SerializeField] GameObject Cloud;

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ResetPosition",5);
        InvokeRepeating("ResetPosition",0, 5);
    }

    // Update is called once per frame
    public void ResetPosition()
    {

        //Debug.Log(Random.Range(0, spawners.Length));

        //int random = Random.Range(5, spawners.Length);
        //Debug.Log(spawners[random].position);


        int random = Random.Range(0, spawners.Length);
        Cloud.transform.position = spawners[random].position;

    }
}
