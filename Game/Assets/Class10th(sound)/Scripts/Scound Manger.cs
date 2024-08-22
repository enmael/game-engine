using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoundManger : MonoBehaviour
{
    private static ScoundManger instance; //������ �������� ������ �ٸ� �޸� ������ �ִ�.

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
