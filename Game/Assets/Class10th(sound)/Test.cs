using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Animator animator;
    public int newCount = 0;
    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }

   //void Update()
   //{
   //     if (newCount < animator.parameters.Cont)
   //     {
   //         animator.Play("Swarm08_Attack");
   //         newCount++;
   //     }
   //     else if( newCount == animator.parameterCount )
   //     {
   //         animator.Play("Swarm08_Die");
   //     }
   //}


}
