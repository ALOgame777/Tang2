using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject targetTail;
    public float speed = 1;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = targetTail.transform.position - transform.position;
    }

    
}
