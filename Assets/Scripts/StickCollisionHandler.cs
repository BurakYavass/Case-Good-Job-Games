using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

  public class StickCollisionHandler : MonoBehaviour
  {
      [SerializeField] private StickController _stickController;
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _waxMask;

      [SerializeField] private GameObject _wax;

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
          Vector3 waxScale = _wax.transform.localScale;
          RaycastHit hit;
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,1000f,_waxMask))
          {
              hit.collider.GetComponent<Renderer>().enabled = true;
              
              if (waxScale.y < 103)
              {
                  waxScale.y += 5f*Time.fixedDeltaTime;
                  _wax.transform.localScale = waxScale;
              }

          }
      }
      
  }
