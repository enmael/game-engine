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
     * ����Ƽ������ �⺻������ ��ũ��Ʈ�� public �ʵ常 ����ȭ�� �� �ֽ��ϴ�.
     * ������ [SerializeField] �� ����Ͽ� private �ʵ带 ����ȭ�� ���� �ֽ��ϴ�. 
     * ��, �ٸ� ��ũ��Ʈ���� �ش� �ʵ带 ������ private ���� ���߸鼭�� ����ȭ�� 
     * ���� ����Ƽ �������� �ν����͸� ���� ���� �Է��� ���������� ���Դϴ�.
     */
    #region ��ī�� �ڽ�
        public float rotationSpeed = 1.0f;
        private Material skyboxMaterial;
    #endregion

    private void Awake()
    {
        move = GetComponent<Moive>();
    }
    void Start()
    {
        #region ��ī�̹ڽ�
        skyboxMaterial = RenderSettings.skybox;
        #endregion
        //move.OnMove();    
        transform.position = new Vector3(0, 0, 0);
    }

   
    void Update()
    {
       
        //Ű �Է�
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


        #region ��ī�̹ڽ�
        if (skyboxMaterial != null)
        {
            float rotation = Time.time * rotationSpeed;
            skyboxMaterial.SetFloat("_Rotation", rotation);
        }

        #endregion
    }

    
}
