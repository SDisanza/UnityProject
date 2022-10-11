using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public GameObject cilindro;
    public GameObject cubo;
    public GameObject salto;
    public Text text;
    private float posizione;

    void Start()
    {
        posizione = cilindro.gameObject.transform.position.y;
    }

    void Update()
    {
        if(posizione > cilindro.gameObject.transform.position.y)
        {
            posizione = cilindro.gameObject.transform.position.y;
        }

        text.text = "Altezza: " + posizione;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject == cubo)
        {
            salto.SetActive(true);
        }        
    }
}