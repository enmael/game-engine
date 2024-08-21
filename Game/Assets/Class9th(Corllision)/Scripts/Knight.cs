using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State // ���¸� �˷��� �ʿ�
{
    WALK,
    ATTACK,
    DIE
}

public class Knight : MonoBehaviour
{
    [SerializeField] State stack; //enm�� ���� ���ؼ� �����;� ��
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

    #region �������� �浹
    private void OnCollisionEnter(Collision collision)
    {
        // �������� �浹�� �Ͼ�� ȣ��Ǵ� �̺�Ʈ �Լ�
        //Debug.Log("OnCollisionEnter");
        //stack = State.ATTACK;
        //Attack();
    }

    private void OnCollisionStay(Collision collision)
    {
        //�������� �浹�� �ϰ� �ִ� ���϶� ȣ��Ǵ� �̺�Ʈ
        //Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // �������� �浹�̳������� ȣ��
        //Debug.Log("OnCollisionExit");
        //stack = State.DIE;
        //Die();
    }

    #endregion

    #region ���������� �ʴ� �浹
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
