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
                    unityEvent.Invoke(); //�ȿ� ����� �Լ����� ȣ�� �ȴ�?
                }

                animator.Rebind(); // �ִ� ���̼� ������ �ֱ�� ���� 
                Debug.Log(animator.GetCurrentAnimatorStateInfo(0).normalizedTime);
                //�̷��� �ϸ� ���ϱ޼������� �þ�� ������ �ذ��� 

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
