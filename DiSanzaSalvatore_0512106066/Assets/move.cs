using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject mattonellaR1, mattonellaR2, mattonellaR3;
    public GameObject mattonellaG1, mattonellaG2, mattonellaG3, mattonellaG4;
    public GameObject gameovertext;
    private bool perso;
    private float forceAmount = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && perso == false)
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.RightArrow) && perso == false)
        {
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.UpArrow) && perso == false)
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }
        
        if(Input.GetKey(KeyCode.DownArrow) && perso == false)
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }

        
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject == mattonellaR1 || collision.gameObject == mattonellaR2 || collision.gameObject == mattonellaR3)
        {
            perso = true;
            gameovertext.SetActive(true);
        }  
        if(collision.gameObject == mattonellaG1)
        {
            mattonellaG1.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        if(collision.gameObject == mattonellaG2) 
        {
            mattonellaG2.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        if(collision.gameObject == mattonellaG3)
        {
            mattonellaG3.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
        if(collision.gameObject == mattonellaG4)
        {
            mattonellaG3.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
        }
    }
}
