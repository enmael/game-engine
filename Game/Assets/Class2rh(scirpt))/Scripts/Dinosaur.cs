using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    private void Awake()
    {
        //Awake 함수 
        // 게임 오브젝트 인스턴스된 직후에 호출되는 함수로,
        // 단 한번만 호출되며, 스크립트가 비활성화된 상태일 때도, 실행됩니다.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        //OnEnable
        // 게임 오브젝트가 활성되었을때 호출되는함수
        Debug.Log("OnEnable");

    }


    void Start()
    {
        // Start 함수
        // 게임 오브젝트가 생성된 후에 호출되는 함수
        // 단 한번만 호출되며, 스크립트가 활성화된 상태일 때만 호출
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        //FixedUpdate 함수
        // timestep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수 

        Debug.Log("FixedUpdate");
    }
    void Update()
    {
        //Update() 함수
        // 프레임 마다 호출되는 이벤트 함수 입니다.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        //LateUpdate() 함수
        // 업데이트 함수가 다 끝나고, 호출되는 이벤트 함수
        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        //OnDisable()
        // 게임 오브젝트가 비활성화 되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        //OnDestroy()
        //게임 오브젝트가 삭제될때 호출
        Debug.Log("OnDestroy");
    }
}
