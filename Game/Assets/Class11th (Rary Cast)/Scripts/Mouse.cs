using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit; //�浹�� ������Ʈ�� ������ ��´�.
    [SerializeField] LayerMask layerMask;
    
    [SerializeField] Texture2D texture2D; //Ŀ�� �������°�?

    //[SerializeField] IInteractale interactale;

    private void Start()
    {
        Cursor.SetCursor(texture2D,new Vector2(0,0) ,CursorMode.Auto); //Ŀ��
    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); //����ī�޶�� 
           // Debug.Log("Ray");
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                //Debug.Log(raycastHit.collider.name); //�浹�� ������Ʈ�� �̸��� ���


                IInteractale interactale = raycastHit.collider.GetComponent<IInteractale>(); //���� ���̽� �ҷ��ͼ� 
                interactale.Interact();


            }
        }
    }

    private void OnDrawGizmos()
    {
        //�ſ��� ������ ���� 
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 0.5f);
    }


}
