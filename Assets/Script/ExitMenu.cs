using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public void goToMenu()
    {
        Debug.Log("Loading Meu....!");
        SceneManager.LoadScene("Menu");
    }

    public void goToExit()
    {
        Debug.Log("Loading Exit....!");
        SceneManager.LoadScene("Exit");
    }


    public void ExitGame()
    {
        Debug.Log("Quit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}