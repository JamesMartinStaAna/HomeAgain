using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAutoTransition : MonoBehaviour
{

    public float currentTime = 0f;
    public float startTime = 5f;
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

        if (currentTime == 0f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}