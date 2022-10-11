using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punti : MonoBehaviour
{
    public static int ValPunti;
    
    void Start()
    {
        ValPunti=0;
    }

    
    void Update()
    {
        GetComponent<Text>().text = ValPunti.ToString();
    }
}
