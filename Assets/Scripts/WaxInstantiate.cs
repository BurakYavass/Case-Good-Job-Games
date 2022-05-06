using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

  public class WaxInstantiate : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _layerMask;

      [SerializeField] private GameObject waxPrefab;

      [SerializeField] private GameObject _rayOperation;
      

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
              if (hit.collider.CompareTag("Wax") && !hit.collider.CompareTag("Particle"))
              {
                  /*Sphere instantiate
                  Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));*/
                  
                  /*Shape instantiate
                  Instantiate(waxPrefab, hit.point,Quaternion.LookRotation(Vector3.zero)).transform.SetParent(_rayOperation.transform);*/
                  
                  GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  wax.transform.SetParent(_rayOperation.transform);
                  _rayOperation.GetComponent<WaxList>()._waxList.Add(wax.transform);
                  
              }
          }
      }
      
  }
