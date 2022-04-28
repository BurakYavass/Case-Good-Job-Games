using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class StickCollisionHandler : MonoBehaviour
  {
      [SerializeField] private StickController _stickController;

      // Update is called once per frame
      void Update()
      {
          

      }

      private void OnTriggerEnter(Collider other)
      {
          if (other.gameObject.CompareTag("Arm"))
          {
              Debug.Log("arm");
          }
      }
  }
