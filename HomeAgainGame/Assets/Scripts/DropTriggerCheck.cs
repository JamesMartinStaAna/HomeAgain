using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DropTriggerCheck : MonoBehaviour
{

    public GameObject activateDrop;
 


    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;

    }
    public void Start()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        //check if object to activate is not null
        if (activateDrop != null)
        {
            // checks if player is withing certain trigger holding their matching objects
            if (collision.CompareTag("Player") && gameObject.tag == "triggerTrash" && GameObject.FindWithTag("crumpledpaper") != null)
            {
                activateDrop.GetComponent<ItemCanvasReceiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerFootStool" && GameObject.FindWithTag("footstool") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerKey" && GameObject.FindWithTag("key") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerDadmug" && GameObject.FindWithTag("dadmug") != null)
            {
                activateDrop.GetComponent<ItemCanvasReceiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerMommug" && GameObject.FindWithTag("mommug") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerMaymug" && GameObject.FindWithTag("maymug") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = true;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerSpoon" && GameObject.FindWithTag("spoon") != null)
            {
                activateDrop.SetActive(true);
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerPlate" && GameObject.FindWithTag("plate") != null)
            {
                activateDrop.SetActive(true);
            }

        }

    }

    private void OnTriggerExit(Collider collision)
    {

        if (activateDrop != null)
        {

            if (collision.CompareTag("Player") && gameObject.tag == "triggerTrash" && GameObject.FindWithTag("crumpledpaper") != null)
            {
                activateDrop.GetComponent<ItemCanvasReceiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerFootStool" && GameObject.FindWithTag("footstool") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerKey" && GameObject.FindWithTag("key") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerDadmug" && GameObject.FindWithTag("dadmug") != null)
            {
                activateDrop.GetComponent<ItemCanvasReceiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerMommug" && GameObject.FindWithTag("mommug") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerMaymug" && GameObject.FindWithTag("maymug") != null)
            {
                activateDrop.GetComponent<Item_Receiver>().enabled = false;
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerSpoon" && GameObject.FindWithTag("spoon") != null)
            {
                activateDrop.SetActive(false);
            }

            if (collision.CompareTag("Player") && gameObject.tag == "triggerPlate" && GameObject.FindWithTag("plate") != null)
            {
                activateDrop.SetActive(false);
            }

        }
    }
}
