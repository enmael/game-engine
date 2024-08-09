using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    private void Awake()
    {
        //Awake �Լ� 
        // ���� ������Ʈ �ν��Ͻ��� ���Ŀ� ȣ��Ǵ� �Լ���,
        // �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ����, ����˴ϴ�.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        //OnEnable
        // ���� ������Ʈ�� Ȱ���Ǿ����� ȣ��Ǵ��Լ�
        Debug.Log("OnEnable");

    }


    void Start()
    {
        // Start �Լ�
        // ���� ������Ʈ�� ������ �Ŀ� ȣ��Ǵ� �Լ�
        // �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� Ȱ��ȭ�� ������ ���� ȣ��
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        //FixedUpdate �Լ�
        // timestep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ� 

        Debug.Log("FixedUpdate");
    }
    void Update()
    {
        //Update() �Լ�
        // ������ ���� ȣ��Ǵ� �̺�Ʈ �Լ� �Դϴ�.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        //LateUpdate() �Լ�
        // ������Ʈ �Լ��� �� ������, ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        //OnDisable()
        // ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy()
        //���� ������Ʈ�� �����ɶ� ȣ��
        Debug.Log("OnDestroy");
    }
}
