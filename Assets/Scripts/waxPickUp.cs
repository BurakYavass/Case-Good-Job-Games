using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class waxPickUp : MonoBehaviour
{
    [SerializeField] private WaxList _wax;
    

    private void Start()
    {
        DOTween.Init();
    }

    void Update()
    {
        if (_wax.listOk)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine(MoveWax());
            }
            
        }
    }

    private IEnumerator MoveWax()
    {
        for (int i = 0; i < _wax._waxList.Count; i++)
        {
            yield return new WaitForSeconds(0.03f);
            _wax._waxList[i].DOMoveY(4, 4);
            yield return null;
        }
    }
}
