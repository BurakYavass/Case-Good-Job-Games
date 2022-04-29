using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class StickController : MonoBehaviour 
 {

     [SerializeField] private Camera camera;
     [SerializeField] private float offSet = 0.5f;
     [SerializeField] private float rayOffSet = 100f;

     [SerializeField] private LayerMask _Mask;
     
     public bool _arm;
     
     private void Start()
     {
         //_armMask = LayerMask.GetMask("Arm");
     }

     void Update()
     {
         MousePosition();
         
     }

     void MousePosition()
     {
         if (Input.GetMouseButton(0))
         {
             Ray ray = camera.ScreenPointToRay(Input.mousePosition + Vector3.left*rayOffSet);

             if (Physics.Raycast(ray, out RaycastHit hitInfo ,1000f ,_Mask))
             {
                 // if (hitInfo.collider.CompareTag("Arm")|| hitInfo.collider.CompareTag("Wax")|| hitInfo.collider.CompareTag("Hair"))
                 // {
                 //     _arm = true;
                 //     transform.position = hitInfo.point+offSet*hitInfo.normal;
                 //     transform.rotation = Quaternion.LookRotation(Vector3.back,hitInfo.normal);
                 //     
                 // }
                 _arm = true;
                 transform.position = hitInfo.point+offSet*hitInfo.normal;
                 transform.rotation = Quaternion.LookRotation(Vector3.back,hitInfo.normal);

             }
             else
             {
                 _arm = false;
             }
         }
     }
 }
