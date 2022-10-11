using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class piedi : MonoBehaviour
{
    public static int caduti;

    void Start()
    {
        caduti = 4;
    }

    void Update()
    {
        GetComponent<Text>().text = caduti.ToString();
    }
}