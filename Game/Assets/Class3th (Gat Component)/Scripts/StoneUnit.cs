using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


[RequireComponent(typeof(Moive))]
public class StoneUnit : MonoBehaviour
{
    
    [SerializeField] Moive move;
    /*
     * 유니티에서는 기본적으로 스크립트의 public 필드만 직렬화할 수 있습니다.
     * 하지만 [SerializeField] 를 사용하여 private 필드를 직렬화할 수도 있습니다. 
     * 즉, 다른 스크립트에서 해당 필드를 여전히 private 으로 감추면서도 직렬화를 
     * 통해 유니티 에디터의 인스펙터를 통한 값의 입력이 가능해지는 것입니다.
     */
    #region 스카이 박스
        public float rotationSpeed = 1.0f;
        private Material skyboxMaterial;
    #endregion

    private void Awake()
    {
        move = GetComponent<Moive>();
    }
    void Start()
    {
        #region 스카이박스
        skyboxMaterial = RenderSettings.skybox;
        #endregion
        //move.OnMove();    
        transform.position = new Vector3(0, 0, 0);
    }

   
    void Update()
    {
       
        //키 입력
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 direction = new Vector3(0, 0, 1);
            move.OnMove(direction);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 direction = new Vector3(0, 0, -1);
            move.OnMove(direction);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 direction = new Vector3(-1, 0, 0);
            move.OnMove(direction);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 direction = new Vector3(1, 0, 0);
            move.OnMove(direction);
        }


        #region 스카이박스
        if (skyboxMaterial != null)
        {
            float rotation = Time.time * rotationSpeed;
            skyboxMaterial.SetFloat("_Rotation", rotation);
        }

        #endregion
    }

    
}
