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
            // gameObject.transform.localScale = Scale;
            //_collider.isTrigger = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hair"))
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            other.GetComponent<Collider>().isTrigger = false;
        }
    }

    IEnumerator DryCounter()
    {
        
        yield return null;
    }

}
