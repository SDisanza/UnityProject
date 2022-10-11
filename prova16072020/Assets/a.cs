using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public bool toccato;
    public GameObject pianoCaduto;
    public GameObject scivoloCaduto;
    public Rigidbody rb;  

    void Start()
    {
        toccato = false;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == scivoloCaduto)
        {
            toccato = true;
            
        }
        if(collision.gameObject == pianoCaduto && toccato == true)
            {
                GetComponent<Renderer>().material.color = new Color(0,0,255);
                game.valCaduti++; 
            }
    }
}