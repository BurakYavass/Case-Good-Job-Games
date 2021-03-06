using UnityEngine;

  public class WaxInstantiate : MonoBehaviour
  {
      [SerializeField] private Transform _rayPoint;

      [SerializeField] private LayerMask _layerMask;

      [SerializeField] private GameObject waxPrefab;

      [SerializeField] private GameObject _rayOperation;

      private bool _particle = false;
      

      void Update()
      {
          if (Input.GetMouseButton(0))
          {
              WaxHit();
          }
      }

      private void OnTriggerEnter(Collider other)
      {
          if (other.gameObject.CompareTag("Particle"))
          {
              _particle = true;
          }
          else
          {
              _particle = false;
          }
      }

      void WaxHit()
      {
          RaycastHit hit;
          if (Physics.Raycast(_rayPoint.transform.position, Vector3.down, out hit,100f,_layerMask))
          {
              if (hit.collider.CompareTag("Wax")&& _particle==false)
              {
                  /*Sphere instantiate
                  Instantiate(waxPrefab, hit.point+hit.normal.normalized*waxPrefab.transform.localScale.x,Quaternion.LookRotation(hit.normal));*/
                  
                  /*Shape instantiate
                  Instantiate(waxPrefab, hit.point,Quaternion.LookRotation(Vector3.zero)).transform.SetParent(_rayOperation.transform);*/
                  
                  GameObject wax = Instantiate(waxPrefab, hit.point, Quaternion.LookRotation(Vector3.zero));
                  wax.transform.SetParent(_rayOperation.transform);
                  _rayOperation.GetComponent<WaxList>()._waxList.Add(wax.transform);
                  
              }
          }
      }
      
  }
