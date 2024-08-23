using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit; //충돌한 오브젝트의 정보를 담는다.
    [SerializeField] LayerMask layerMask;
    
    [SerializeField] Texture2D texture2D; //커서 가져오는거?

    //[SerializeField] IInteractale interactale;

    private void Start()
    {
        Cursor.SetCursor(texture2D,new Vector2(0,0) ,CursorMode.Auto); //커서
    }
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition); //메인카메라로 
           // Debug.Log("Ray");
            if(Physics.Raycast(ray, out raycastHit, Mathf.Infinity, layerMask))
            {
                //Debug.Log(raycastHit.collider.name); //충돌된 오브젝트의 이름을 출력


                IInteractale interactale = raycastHit.collider.GetComponent<IInteractale>(); //인터 페이스 불러와서 
                interactale.Interact();


            }
        }
    }

    private void OnDrawGizmos()
    {
        //신에서 광선이 보임 
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 0.5f);
    }


}
