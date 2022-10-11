using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inizio : MonoBehaviour
{
    void Update()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
    }
}