using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public static int valCaduti;

    void Start()
    {
        valCaduti=0;
    }

    void Update()
    {
        GetComponent<Text>().text = valCaduti.ToString();
    }

    
}