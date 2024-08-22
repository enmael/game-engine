using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoundManger : MonoBehaviour
{
    private static ScoundManger instance; //데이터 영역으로 잡히기 다른 메모리 공간에 있다.

    public static ScoundManger Instance
    {
        get { return instance; }
        set { instance = value; }   
    }

    [SerializeField] AudioSource effectaudioSource;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Sound(AudioClip audioClip)
    {
        effectaudioSource.PlayOneShot(audioClip);
    }

    

}
