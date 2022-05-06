using UnityEngine;

public class WaxPartCollHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wax"))
        {
            _rb.isKinematic = true;
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
}
