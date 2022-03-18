using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)

    { 
        if (other.gameObject.CompareTag("Collected"))
        {
            Destroy(other.gameObject);
        }
    
         

        
      



    }

}
