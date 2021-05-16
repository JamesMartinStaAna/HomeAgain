using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object_Activator_Chapter1 : MonoBehaviour
{
    Collider box_Collider;


    public GameObject boxObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("lockNkey") != null)
        {
            box_Collider = boxObject.GetComponent<Collider>();

        }
    }
}
