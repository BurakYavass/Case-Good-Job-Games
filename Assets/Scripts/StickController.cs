using UnityEngine;

 public class StickController : MonoBehaviour 
 {

     [SerializeField] private Camera camera;
     [SerializeField] private float offSet = 0.5f;
     [SerializeField] private float rayOffSet = 100f;
     [SerializeField] private WaxList _waxList;
     [SerializeField] private LayerMask _Mask;
     
     public bool _arm;
     void Update()
     {
         MousePosition();
         
         if (_waxList.waxFinished)
         {
             gameObject.SetActive(false);
         }
     }

     void MousePosition()
     {
         if (Input.GetMouseButton(0))
         {
             Ray ray = camera.ScreenPointToRay(Input.mousePosition + Vector3.left*rayOffSet);

             if (Physics.Raycast(ray, out RaycastHit hitInfo ,100f ,_Mask))
             {
                 _arm = true;
                 transform.position = hitInfo.point+offSet*hitInfo.normal;
                 //transform.rotation = Quaternion.LookRotation(Vector3.back,hitInfo.normal);
             }
             else
             {
                 _arm = false;
             }
         }
     }
 }
