using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{

    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 direcion;

    void Start()
    {
        
    }


    void Update()
    {

        //direcion.z = Input.GetAxis("Vertical");

        direcion.x = Input.GetAxisRaw("Horizontal");
        direcion.z = Input.GetAxisRaw("Vertical");
        
        //백터의 정규화 
        direcion.Normalize();


        //p  = p0 + vt
        // Time.deltaTime: 마지막 프레임이 완료된 후 경과한 시간을 초 단위로 반환하는 값
        transform.position = transform.position + direcion * speed * Time.deltaTime;

    }
}
