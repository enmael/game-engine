using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramdos : MonoBehaviour
{
    [SerializeField] GameObject[] gameObject2 ;
    public float x; // X축 랜덤 범위
    public float y; // Y축 랜덤 범위
    public float z; // Z축 랜덤 범위

   
    private void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        for(int i = 0; i < 10; i++) 
        {
                // 랜덤 위치 생성
                float xPos = Random.Range(-x, x);
                float yPos = Random.Range(-y, y);
                float zPos = Random.Range(-z, z);
           
                Vector3 randomPosition = new Vector3(xPos, yPos, zPos);

            if (i >= 0 && i <5)
            {
                Instantiate(gameObject2[i], randomPosition, Quaternion.identity);
            }
            else if(i>=5 && i < 10) 
            {
                Instantiate(gameObject2[i-5], randomPosition, Quaternion.identity);
            }
        }

    }

}


