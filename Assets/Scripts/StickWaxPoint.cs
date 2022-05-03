using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

  public class StickWaxPoint : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _layerMask;

      [SerializeField] private GameObject waxPrefab;

      [SerializeField] private Transform _operationTransform;
      
      void Update()
      {
          if (Input.GetMouseButton(0))
          {
              WaxHit();
          }
          
      }

      // ReSharper disable Unity.PerformanceAnalysis
      void WaxHit()
      {
          RaycastHit hit;
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,100f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax") && !hit.collider.CompareTag("Particle"))
              {
                  Debug.Log(hit.collider.tag+" "+hit.collider.name);
                  //Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));
                  Instantiate(waxPrefab, hit.point,Quaternion.LookRotation(hit.normal)).transform.SetParent(_operationTransform);
              }

              if (hit.collider.CompareTag("Particle"))
              {
                  Debug.Log("Particle");
              }

          }
      }
      
  }
