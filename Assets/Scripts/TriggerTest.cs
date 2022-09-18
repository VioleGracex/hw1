using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /*  private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Прозошло столкновение с " + other.gameObject.name);
        other.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        
    }
     private void OnTriggerExit(Collider other)
    {
        Debug.Log("Завершенно столкновение с "+ other.gameObject.name);
        other.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        
    } */

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        }
    }
    private void OnCollisionExiT(Collision other)
    {
        if (other.gameObject.name == "Cube")
        {
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        }
    }
}
