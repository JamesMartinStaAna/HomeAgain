using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DropTriggerCheck2 : MonoBehaviour
{

    public GameObject activateBoxDrop;
    public GameObject activateLockDrop;
    public GameObject activateMoonDrop;



    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;

    }
    public void Start()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {


        if (collision.CompareTag("Player") && gameObject.tag == "triggerBox" && GameObject.FindWithTag("boxItem") != null)
        {
            activateBoxDrop.GetComponent<DropItemNactivate2>().enabled = true;
        }

        if (collision.CompareTag("Player") && gameObject.tag == "triggerLock" && GameObject.FindWithTag("lockNkey") != null)
        {
            activateLockDrop.GetComponent<DropItemNactivate2>().enabled = true;
        }

        if (collision.CompareTag("Player") && gameObject.tag == "triggerMoon" && GameObject.FindWithTag("fullMoon") != null)
        {
            activateMoonDrop.GetComponent<DropItemNactivate2>().enabled = true;
        }


    }

    private void OnTriggerExit(Collider collision)
    {


        if (collision.CompareTag("Player") && gameObject.tag == "triggerBox" && GameObject.FindWithTag("boxItem") != null)
        {
            activateBoxDrop.GetComponent<DropItemNactivate2>().enabled = false;
        }

        if (collision.CompareTag("Player") && gameObject.tag == "triggerLock" && GameObject.FindWithTag("lockNkey") != null)
        {
            activateLockDrop.GetComponent<DropItemNactivate2>().enabled = false;
        }

        if (collision.CompareTag("Player") && gameObject.tag == "triggerMoon" && GameObject.FindWithTag("fullMoon") != null)
        {
            activateMoonDrop.GetComponent<DropItemNactivate2>().enabled = false;
        }

    }
}
