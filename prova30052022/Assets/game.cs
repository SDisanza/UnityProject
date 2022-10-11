using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public GameObject muro1;
    public GameObject muro2;
    public GameObject muro3;
    public GameObject muro4;
    public GameObject muro5;
    public GameObject muroDoro;
    public GameObject cubo;
    public GameObject muroW;
    public GameObject gameoverbutton;
    public GameObject scrittaW;
    public int moveSpeed = 10;
    public bool perso = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && perso == false)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) && perso == false)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow) && perso == false)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.DownArrow) && perso == false)
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject == muro1 || collision.gameObject == muro2 || collision.gameObject == muro3 || collision.gameObject == muro4 || collision.gameObject == muro5)
        {
            perso = true;
            gameoverbutton.SetActive(true);
        }

        if(collision.gameObject == cubo)
        {
            Destroy(muroDoro);
        }
        if(collision.gameObject == muroW)
        {
            perso = true;
            scrittaW.SetActive(true);
        }
    }
}