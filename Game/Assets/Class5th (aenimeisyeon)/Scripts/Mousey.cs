using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousey : MonoBehaviour
{

    [SerializeField] Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) 
        {
            //if(animator.GetCurrentAnimatorClipInfo(0).IsName("Run") == false)
            //{
                animator.SetTrigger("Run");

            //}
        }
        
        if(Input.GetKeyDown(KeyCode.S)) 
        {
            animator.SetTrigger("seate idI");
        }
    }
}
