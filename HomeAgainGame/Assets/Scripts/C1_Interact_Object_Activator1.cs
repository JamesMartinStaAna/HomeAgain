using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_Interact_Object_Activator1 : MonoBehaviour
{
    Collider key_Collider;


    public GameObject keyObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("brokenDoll") != null)
        {
            key_Collider = keyObject.GetComponent<Collider>();


            key_Collider.enabled = true;

        }
    }
}
