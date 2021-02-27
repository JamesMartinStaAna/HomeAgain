using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

   public void PlayGame()
    {
        SceneManager.LoadScene("May_Bedroom");
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
