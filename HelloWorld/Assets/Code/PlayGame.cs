using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayGame : MonoBehaviour
{
    public void ClickStart()
    {
        move.perso = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void ClickQuit()
    {
        Application.Quit();
    }

    public void ClickRestart()
    {
        move.perso = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClickMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
}