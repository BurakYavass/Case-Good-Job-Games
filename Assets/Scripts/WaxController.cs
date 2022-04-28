using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hair"))
        {
            //collision.gameObject.transform.parent = gameObject.transform;
            collision.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Hair"))
    //     {
    //         Debug.Log("Hair");
    //         other.gameObject.transform.parent = gameObject.transform;
    //         other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    //     }
    // }
}
