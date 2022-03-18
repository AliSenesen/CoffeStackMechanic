using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
   

          private  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coffee"))
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
