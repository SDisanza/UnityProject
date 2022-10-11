using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int moveSpeed = 100;
    public float forceAmount = 10.0f;
    public GameObject Parete1;
    public GameObject Parete2;
    public GameObject Parete3;
    public GameObject Parete4;
    public GameObject PareteCentrale;
    public GameObject GameOver;
    public GameObject gameoverbutton;
    public GameObject restartbutton;
    public static bool perso;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
       /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }*/

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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == Parete4)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
            punti.ValPunti++;
        }

        if(collision.gameObject == PareteCentrale)
        {
            GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
            punti.ValPunti++;
        }

        if(collision.gameObject == GameOver)
        {
           perso = true;
           gameoverbutton.SetActive(true);
           restartbutton.SetActive(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject == Parete1)
        {
            Destroy(Parete1);
            punti.ValPunti+=5;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject == Parete2)
        {
            Parete2.GetComponent<Renderer>().material.color = Color.Lerp(Parete2.GetComponent<Renderer>().material.color, new Color(Random.value, Random.value, Random.value, Random.value), Random.value);
            punti.ValPunti+=2;
        }
    }
}