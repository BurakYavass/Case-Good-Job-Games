using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxPartCollHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Renderer _renderer;
    private Material _mat;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wax"))
        {
            _rb.isKinematic = true;
            StartCoroutine(SetMaterial());
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

    private IEnumerator SetMaterial()
    {
        yield return new WaitForSeconds(1);
        //var newMaterials = new Material[1];
        var newMat = _renderer.materials;
        newMat[0] = _mat;
        //newMaterials[0] = _mat;
        _renderer.materials = newMat;
        yield return null;
    }
}
