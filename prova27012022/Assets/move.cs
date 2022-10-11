using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public int moveSpeed = 10;
    public float forceAmount = 10.0f;
    public bool vinto = false;
    public GameObject finish;
    public GameObject winbutton;
    public GameObject gameoverbutton;
    public Renderer rd;
    public Material material;

    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(rb.position.y<-1 && vinto == false)
        {
            gameoverbutton.SetActive(true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
           rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
           rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
           rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == finish)
        {
            vinto = true;
            winbutton.SetActive(true);
            rb.velocity = Vector3.zero;
        }
    }

    public void Click()
    {
        rd.material=material;
    }
}