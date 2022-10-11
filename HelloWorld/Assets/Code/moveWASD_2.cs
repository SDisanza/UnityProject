using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class moveWASD_2 : MonoBehaviour
{
    public int moveSpeed = 100;
    public float forceAmount = 10.0f;
    public Rigidbody rb;

    

    /*public void ClickW()
    {
        if(move.perso == false /*&& Event.onPressedOverSeconds != null/*Event.buttonPressed == true)
        {
           rb.AddForce(Vector3.forward * forceAmount, ForceMode.Impulse);
        }
    }

    public void ClickA()
    {
        if(move.perso == false /*&& Event.buttonPressed == true)
        {     
            rb.AddForce(Vector3.left * forceAmount, ForceMode.Impulse);
        }   
 }

    public void ClickS()
    {
        if(move.perso == false /*&& Event.buttonPressed == true)
        {
            rb.AddForce(Vector3.back * forceAmount, ForceMode.Impulse);
        }
    }

    public void ClickD()
    {
        if(move.perso == false /*&& Event.buttonPressed == true)
        {
           rb.AddForce(Vector3.right * forceAmount, ForceMode.Impulse);
        }
    }

    public void ClickSpace()
    {
        if(move.perso == false /*&& Event.buttonPressed == true)
        {
            rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
        }
    }*/
}
