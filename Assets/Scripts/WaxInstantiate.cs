using System.Collections.Generic;
using UnityEngine;

  public class WaxInstantiate : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _layerMask;

      [SerializeField] private GameObject waxPrefab;

      [SerializeField] private WaxList _list;

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
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,1000f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax"))
              {
                  //Sphere instantiate
                  //GameObject wax = Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));
                  Debug.Log(hit.collider.tag);
                  GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  wax.transform.SetParent(hit.collider.transform);
                  _list._waxList.Add(wax.transform);
                  
                  /*Shape instantiate
                  Instantiate(waxPrefab, hit.point,Quaternion.LookRotation(Vector3.zero)).transform.SetParent(_rayOperation.transform);*/
                  
                  // GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  // wax.transform.SetParent(_rayOperation.transform);
                  //rayOperation.GetComponent<WaxList>()._waxList.Add(wax.transform);
                  
              }
          }
      }
      
  }
