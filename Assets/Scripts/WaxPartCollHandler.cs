using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxPartCollHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Collider _collider;
    [SerializeField] private RaymarchShape _raymarchShape;
    

    private void Awake()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wax"))
        {
            _rb.isKinematic = true;
            
            // Vector3 Scale = gameObject.transform.localScale;
            // Scale.y = 0.01f;
            // gameObject.transform.localScale = Scale;
            //_collider.isTrigger = true;
        }
    }

    IEnumerator DryCounter()
    {
        
        yield return null;
    }

}
