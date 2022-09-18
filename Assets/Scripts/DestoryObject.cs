using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObject : MonoBehaviour
{
    [SerializeField] 
    float radius = 5.0f;

    [SerializeField] 
    float force = 10.0f;
    [SerializeField] 
    LayerMask bounceSpheres;

    [SerializeField] 
    public GameObject prefabBoomPoint;
    [SerializeField] 
    public GameObject prefabBoomSphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Sphere")
        {
            Destroy(other.gameObject,1.2f);
            Vector3 boomPosition = other.gameObject.transform.position;
            Instantiate(prefabBoomPoint,other.gameObject.transform.position, other.gameObject.transform.rotation);
            Instantiate(prefabBoomSphere,other.gameObject.transform.position, other.gameObject.transform.rotation);
            Collider[] colliders = Physics.OverlapSphere(boomPosition,radius,bounceSpheres);
            foreach(Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if(rb !=null)
                {
                    rb.AddExplosionForce(force,boomPosition,radius,3.0f);
                }
            }
        }
    }
}
