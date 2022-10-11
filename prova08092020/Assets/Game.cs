using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    private int numberOfClone = 1;
    public float spawnTime;
    public float spawnRate = 5f;
    public GameObject Plane;
    public GameObject Muro2;
    public GameObject Muro3;
    public GameObject cilindro;
    public GameObject cilindri;
    public GameObject objs; 
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //objs = (GameObject)Instantiate(cilindri, new Vector3(-6, 36, -82), new Quaternion());

        if (Input.GetKeyDown("g"))
        {
           objs = (GameObject)Instantiate(cilindri, new Vector3(23, -15, 122), new Quaternion());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == Plane)
        {
            TextInc.TextN++;
        }

        if(collision.gameObject == Muro2 || collision.gameObject == Muro3)
        {
            Destroy(cilindro);
        }
    }

}