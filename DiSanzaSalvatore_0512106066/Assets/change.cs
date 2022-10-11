using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    public void OnClickColor()
    {
        rb.GetComponent<Renderer>().material.color = new Color(0.18f,0.21f,0.25f);
    } 
    public void OnClickColor2()
    {
        rb.GetComponent<Renderer>().material.color = new Color(0.6f,0.32f,0.28f);
    } 
}