using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject muro;
    public GameObject muro1;
    public GameObject muro2;
    public GameObject muro3;
    public GameObject scrittaP;
    public GameObject scrittaW;
    public GameObject win;
    public Rigidbody rb;
    private bool perso = false;
    public float forceAmount = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.A) && perso == false)
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.D) && perso == false)
        {
            rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.W) && perso == false)
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.S) && perso == false)
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.Space) && perso == false)
        {
            rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == muro || collision.gameObject == muro1 || collision.gameObject == muro2 || collision.gameObject == muro3)
        {
            perso = true;
            scrittaP.SetActive(true);
        }
        
        if(collision.gameObject == win)
        {
            perso = true;
            scrittaW.SetActive(true);
        }
    }
}
