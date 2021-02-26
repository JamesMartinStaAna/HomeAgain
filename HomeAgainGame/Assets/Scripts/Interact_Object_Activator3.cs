using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object_Activator3 : MonoBehaviour
{
    Collider footstool_Collider;
    Collider kitchenCabinet_Collider;


    public GameObject FootstoolObject;
    public GameObject kitchenCabinetObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Spoon_drop ") == null && GameObject.Find("kitchen counter open default") != null)
        {
            footstool_Collider = FootstoolObject.GetComponent<Collider>();
            kitchenCabinet_Collider = kitchenCabinetObject.GetComponent<Collider>();
            footstool_Collider.enabled = true;
            kitchenCabinet_Collider.enabled = true;
        }
    }
}
