using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class waxPickUp : MonoBehaviour
{
    [SerializeField] private WaxList _wax;
    
    private bool pickup = false;

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
                pickup = true;
            }

            if (pickup)
            {
                for (int i = 0; i < _wax._waxList.Count; i++)
                {
                    _wax._waxList[i].DOMoveY(4, 4);
                }
            }
        }
    }
}
