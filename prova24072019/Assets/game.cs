using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject buca;
    public bool centrato;
    public int forceAmount;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * forceAmount * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * forceAmount * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == buca)
        {
            punti.ValPunti++;
            centrato = true;
        }
    }
}
