using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaxList : MonoBehaviour
{
    public List<Transform> _waxList = new List<Transform>();
    public bool waxFinished = false;

    void Update()
    {
        if (_waxList.Count == 16)
        {
            waxFinished = true;
        }

        if (waxFinished)
        {
            List<Transform> sortPosZ = _waxList.OrderBy(wax => wax.position.z).ToList();
            _waxList.Clear();
            _waxList.AddRange(sortPosZ);
            
            // foreach (var trans in _waxList)
            // {
            //     _pos = trans.transform.position;
            // }
            
            //_waxList.OrderBy(a => a.position.z).ToList();


        }
    }
}
