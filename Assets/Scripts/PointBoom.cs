using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBoom : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    float radius = 5.0f;

    [SerializeField] 
    float force = 10.0f;
    [SerializeField] 
    LayerMask bounceSpheres;
    void Start()
    {
        Vector3 boomPosition = transform.position;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
