using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_Fade : MonoBehaviour
{

    public float currentTime = 0f;
    private float startTime = 1f;
    public GameObject transition;
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

        if (GameObject.FindWithTag("transition") != null && currentTime == 0f)
        {
            transition.SetActive(false);
        }
    }
}
