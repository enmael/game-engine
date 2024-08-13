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
        
        //������ ����ȭ 
        direcion.Normalize();


        //p  = p0 + vt
        // Time.deltaTime: ������ �������� �Ϸ�� �� ����� �ð��� �� ������ ��ȯ�ϴ� ��
        transform.position = transform.position + direcion * speed * Time.deltaTime;

    }
}
