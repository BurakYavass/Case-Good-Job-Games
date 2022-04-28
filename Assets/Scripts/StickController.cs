using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class StickController : MonoBehaviour 
 {

     [SerializeField] private Camera camera;

     public bool _arm;
     

     void Update()
     {
         MousePosition();
     }

     void MousePosition()
     {
         if (Input.GetMouseButton(0))
         {
             Ray ray = camera.ScreenPointToRay(Input.mousePosition);

             if (Physics.Raycast(ray, out RaycastHit hitInfo))
             {
                 if (hitInfo.collider.gameObject.CompareTag("Arm"))
                 {
                     //Debug.Log("Arm");
                     _arm = true;
                     transform.position = hitInfo.point;
                 }
                 else
                 {
                     _arm = false;
                 }
             }
         }
     }
 }
