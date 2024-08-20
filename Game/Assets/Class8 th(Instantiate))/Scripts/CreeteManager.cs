using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class CreeteManager : MonoBehaviour
{
    [SerializeField] int creatreCount;
    [SerializeField] GameObject clonObject;
    [SerializeField] GameObject[] prefabs;


    //public float sum;
    // Start is called before the first frame update


    private void Awake()
    {
       
    }
    void Start()
    {
        //Instantiate(prefab);

        //clonObject = Instantiate(prefab);

        //clonObject.transform.position = new Vector3 (1, 1, 1);

        StartCoroutine(Create());  //이것도 좋은 방법이아니다 가비지가 5초마다 생성되는 안좋다.
    }


    void Update()
    {

        //sum += Time.deltaTime;

        //if(sum >= 5.0f)
        //{
        //    clonObject = Instantiate(prefab);
        //    sum = 0.0f;
        //}


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(clonObject);
        }



    }

    IEnumerator Create()
    {

        while (creatreCount < 4)
        {
            if (clonObject == null)
            {
                clonObject = Instantiate(prefabs[creatreCount++]);
            }

            yield return new WaitForSeconds(5f);
        }

        //while (true)
        //{
        //    clonObject = Instantiate(prefab);

        //    yield return new WaitForSeconds(5f); //양보하는 린턴 세상에 5초마다 일

        //}
    }
}
