using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInc : MonoBehaviour
{
    
    public static int TextN;
    
    void Start()
    {
        TextN=0;
    }

    
    void Update()
    {
       GetComponent<Text>().text = TextN.ToString();
    }
}
