using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class Character : MonoBehaviour
{
    [SerializeField] Animator animator;

    [SerializeField] UnityEvent unityEvent;
    [SerializeField] UnityEvent unityEvent2;
    [SerializeField] UnityEvent unityEvent3;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }

    private void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
        {
            if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {

                if(unityEvent != null)
                {
                    unityEvent.Invoke(); //안에 저장된 함수를이 호출 된다?
                }

                animator.Rebind(); // 애니 메이션 끝나는 주기로 실행 
                Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                //이렇게 하면 기하급수적으로 늘어나는 문제를 해결함 

            }
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            unityEvent3.Invoke();
        }

    }

    private void LateUpdate()
    {
        unityEvent2.Invoke();
    }


}
