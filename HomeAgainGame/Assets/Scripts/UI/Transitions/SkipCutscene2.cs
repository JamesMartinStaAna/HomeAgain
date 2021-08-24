using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCutscene2 : MonoBehaviour
{
    public GameObject skip1;
    public GameObject skip2;

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
        Destroy(skip1);
        Destroy(skip2);
    }
}
