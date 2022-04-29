using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxParticleCollisionHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Collider _collider;
    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Arm"))
        {
            //gameObject.transform.SetParent(other.gameObject.transform.parent);
            _rb.isKinematic = true;
            //_collider.isTrigger = true;
            //_rb.isKinematic = true;

        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Wax"))
    //     {
    //         gameObject.transform.SetParent(other.gameObject.transform);
    //     }
    // }
}
