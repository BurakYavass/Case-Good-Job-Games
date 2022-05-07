using System.Collections.Generic;
using UnityEngine;

  public class WaxInstantiate : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint,_rayPoint2,_rayPoint3;

      [SerializeField] private LayerMask _layerMask;

      [SerializeField] private GameObject waxPrefab;

      [SerializeField] private WaxList _list;

      private bool waxCollider = false;

      void Update()
      {
          if (Input.GetMouseButton(0))
          {
              WaxHit();
          }
      }
      

      void WaxHit()
      {
          RaycastHit hit;
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,100f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax"))
              {
                  GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(hit.normal));
                  wax.transform.SetParent(hit.collider.transform);
                  _list._waxList.Add(wax.transform);
                  
                  //Sphere instantiate
                  //GameObject wax = Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));

                  /*Shape instantiate
                  Instantiate(waxPrefab, hit.point,Quaternion.LookRotation(Vector3.zero)).transform.SetParent(_rayOperation.transform);*/
              
                  // GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  // wax.transform.SetParent(_rayOperation.transform);
                  //rayOperation.GetComponent<WaxList>()._waxList.Add(wax.transform);
              }
          }
          
          if (Physics.Raycast(_rayPoint2.transform.position, Vector3.down, out hit,100f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax"))
              {
                  GameObject wax2 = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  wax2.transform.SetParent(hit.collider.transform);
                  _list._waxList.Add(wax2.transform);
              }
          }
          
          if (Physics.Raycast(_rayPoint3.transform.position, Vector3.down, out hit,100f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax"))
              {
                  GameObject wax3 = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  wax3.transform.SetParent(hit.collider.transform);
                  _list._waxList.Add(wax3.transform);
              }
          }
      }
      
  }
