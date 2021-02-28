using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScript : MonoBehaviour
{

    public float currentTime = 0f;
    public float startTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

        if (this.gameObject != null && currentTime == 0f)
        {
            Destroy(gameObject);
            currentTime = 2f;
        }
    }

    public void OnDestroy()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}