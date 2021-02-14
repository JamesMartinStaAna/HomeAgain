using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
   public Animator animator;

   public void PlayGame()
    {
        SceneManager.LoadScene("May_Bedroom");
    }

}
