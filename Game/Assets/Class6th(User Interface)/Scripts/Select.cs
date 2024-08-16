using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [SerializeField] GameObject selectObject;
    
    public void OnEnter()
    {
        selectObject.SetActive(true);
        
    }
    public void OnExit()
    {
        selectObject.SetActive(false);
    }
}
