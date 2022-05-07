using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WaxList : MonoBehaviour
{
    public List<Transform> _waxList = new  List<Transform>();
    public bool waxFinished = false;
    public bool listOk = false;

    void FixedUpdate()
    {
        if (_waxList.Count >= 200)
        {
            waxFinished = true;
        }

        if (waxFinished)
        {
            List<Transform> sortPosZ = _waxList.OrderBy(wax => wax.position.z).ToList();
            _waxList.Clear();
            _waxList.AddRange(sortPosZ);
            listOk = true;
        }
    }
}
