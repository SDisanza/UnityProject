using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Start()
    {
        //transform.LookAt(sphere.transform);
    }

    void Update()
    {
        transform.position = player.position + offset;
    }
}
