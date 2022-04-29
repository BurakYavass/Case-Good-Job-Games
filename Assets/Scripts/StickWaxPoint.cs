using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

  public class StickWaxPoint : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _waxMask;

      [SerializeField] private GameObject waxPrefab;

      private float waxColliderRadius;

      private void Start()
      {
          waxColliderRadius = waxPrefab.GetComponent<SphereCollider>().radius;

      }

      // Update is called once per frame
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
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,1000f,_waxMask))
          {
              if (hit.collider.CompareTag("Arm"))
              {
                  Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxColliderRadius*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));
              }
              
          }
      }
      
  }
