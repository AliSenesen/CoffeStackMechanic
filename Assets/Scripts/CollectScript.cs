using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectScript>());
            other.gameObject.AddComponent<CollectScript>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMove>();
            other.gameObject.GetComponent<NodeMove>().connectedNode = transform;
            other.gameObject.tag = "Collected";
        }

    }

}
