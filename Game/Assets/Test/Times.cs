using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Times : MonoBehaviour
{
    public Text text;
    public float time;
    private float selectContdown;


    private void Start()
    {
        selectContdown = time;
    }

    private void Update()
    {
        if (Mathf.Floor(selectContdown) <= 0)
        {
            text.text = " Game over";
        }
        else
        {
            selectContdown -= Time.deltaTime;
            text.text = Mathf.Floor(selectContdown).ToString();    
        }
    }
}
