using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State // 상태를 알려면 필요
{
    WALK,
    ATTACK,
    DIE
}

public class Knight : MonoBehaviour
{
    [SerializeField] State stack; //enm을 쓰기 위해서 가져와야 함
    [SerializeField] Animator animator;
    [SerializeField] float speed = 2.5f;
    
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
         
    }

    void Start()
    {
     
    }

    public void Walk()
    {
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Attack()
    {
        animator.SetBool("Attack", true);
    }

    public void Die()
    {
        animator.Play("Die");
    }

    // Update is called once per frame
    void Update()
    {
        switch (stack)
        {
            case State.WALK:
                Walk();
                break;
            case State.ATTACK:
                Attack();
                break;
            case State.DIE:
                Die();
                break;
        }

    }

    #region 물리적인 충돌
    private void OnCollisionEnter(Collision collision)
    {
        // 물리적인 충돌이 일어날때 호출되는 이벤트 함수
        //Debug.Log("OnCollisionEnter");
        //stack = State.ATTACK;
        //Attack();
    }

    private void OnCollisionStay(Collision collision)
    {
        //물리적인 충돌을 하고 있는 중일때 호출되는 이벤트
        //Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // 물리적인 충돌이끝났을때 호출
        //Debug.Log("OnCollisionExit");
        //stack = State.DIE;
        //Die();
    }

    #endregion

    #region 물리적이지 않느 충돌
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enenmy"))
        {
            Debug.Log("OnCollisionEnter");
            stack = State.ATTACK;
        }
        Debug.Log("OnTriggerEnter");

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enenmy"))
        {
            Debug.Log("OnCollisionExit");
            stack = State.DIE;
        }
        //Debug.Log("OnTriggerExit");
    }

    #endregion
}
