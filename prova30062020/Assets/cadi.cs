using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cadi : MonoBehaviour
{
    /*public Rigidbody muro1;
    public Rigidbody muro2;
    public Rigidbody muro3;
    public Rigidbody muro4;
    public GameObject cilindroC;*/
    public Rigidbody cilindro;
    public GameObject buttonStrike;
    public GameObject muro1;
    public GameObject muro2;
    public GameObject muro3;
    public GameObject muro4;
    //public GameObject tessere;
    
    private bool controllo1;
    private bool controllo2;
    private bool controllo3;
    private bool controllo4;


    void Start()
    {
        controllo1 = true;
        controllo2 = false;
        controllo3 = false;
        controllo4 = false;
        cilindro = GetComponent<Rigidbody>();
        /*muro1 = GetComponent<Rigidbody>();
        muro2 = GetComponent<Rigidbody>();
        muro3 = GetComponent<Rigidbody>();
        muro4 = GetComponent<Rigidbody>();*/
    }

    void Update()
    {
        if(piedi.caduti == 0)
        {
            buttonStrike.SetActive(true);
        }

        if(cilindro.transform.position.y < 0)
        {
            buttonStrike.SetActive(true);
        }

        if(muro1.transform.position.y < 1.5 && controllo1 == true)
        {
            controllo1 = false;
            piedi.caduti--;
            controllo2 = true;
        }
        if(muro2.transform.position.y < 1.5 && controllo2 == true)
        {
            controllo2 = false;
            piedi.caduti--;
            controllo3 = true;
        }
        if(muro3.transform.position.y < 1.5 && controllo3 == true)
        {
            controllo3 = false;
            piedi.caduti--;
            controllo4 = true;
        }
        if(muro4.transform.position.y < 1.5 && controllo4 == true)
        {
            controllo4 = false;
            piedi.caduti--;
        }
    }

    /*private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject == muro1)
        {
            Destroy(muro1);
        }

         if(collision.gameObject == muro2)
        {
            Destroy(muro2);
        }

         if(collision.gameObject == muro3)
        {
            Destroy(muro3);
        }

         if(collision.gameObject == muro4)
        {
            Destroy(muro4);
        }
    }*/
}