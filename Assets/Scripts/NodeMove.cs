using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMove : MonoBehaviour
{
    public Transform connectedNode;
    

    
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedNode.position.x, Time.deltaTime * 20),
            connectedNode.position.y,
            connectedNode.position.z + 1.5f
            
            );
            
    }
}
