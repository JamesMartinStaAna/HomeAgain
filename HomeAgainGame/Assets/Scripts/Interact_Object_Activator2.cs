using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object_Activator2 : MonoBehaviour
{
    Collider key_Collider;
    Collider spoon_Collider;


    public GameObject keyObject;
    public GameObject spoonObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Maymug_drop") == null && GameObject.Find("Dadmug_drop") == null && GameObject.Find("Mommug_drop") == null)
        {
            key_Collider = keyObject.GetComponent<Collider>();
            spoon_Collider = spoonObject.GetComponent<Collider>();

            key_Collider.enabled = true;
            spoon_Collider.enabled = true;
        }
    }
}
