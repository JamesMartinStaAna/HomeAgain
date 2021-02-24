using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isActive;

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;

            if (isActive)
            {
                pauseMenu.SetActive(true);

                Time.timeScale = 0;
            }
            else
            {

                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }

        }





    }
}
