using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartMethod : MonoBehaviour
{
    [SerializeField] private RaymarchControl _raymarchControl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _raymarchControl.enabled = true;
        }
    }
}
