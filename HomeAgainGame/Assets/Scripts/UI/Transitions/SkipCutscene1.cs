using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCutscene1 : MonoBehaviour
{
    public GameObject skipThis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Skip()
    {
        Destroy(skipThis);
    }
}
