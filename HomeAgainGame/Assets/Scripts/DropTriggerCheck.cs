using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DropTriggerCheck : MonoBehaviour
{

    public GameObject activateFootstoolDrop;
    public GameObject activateKeyDrop;
    public GameObject activateDadMugDrop;
    public GameObject activateMomMugDrop;
    public GameObject activateMayMugDrop;
    public GameObject activateSpoonDrop;
    public GameObject activatePlateDrop;


    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;

    }
    public void Start()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {


        if ((collision.CompareTag("Player") && gameObject.tag == "triggerFootStool") && GameObject.FindWithTag("footstool") != null)
        {
            activateFootstoolDrop.GetComponent<DropItemNactivate>().enabled = true;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerKey") && GameObject.FindWithTag("key") != null)
        {
            activateKeyDrop.GetComponent<DropItemNactivate>().enabled = true;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerDadmug") && GameObject.FindWithTag("dadmug") != null)
        {
            activateDadMugDrop.GetComponent<DropItemNactivate>().enabled = true;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMommug") && GameObject.FindWithTag("mommug") != null)
        {
            activateMomMugDrop.GetComponent<DropItemNactivate>().enabled = true; 
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMaymug") && GameObject.FindWithTag("maymug") != null)
        {
            activateMayMugDrop.GetComponent<DropItemNactivate>().enabled = true;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerSpoon") && GameObject.FindWithTag("spoon") != null)
        {
            activateSpoonDrop.SetActive(true);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerPlate") && GameObject.FindWithTag("plate") != null)
        {
            activatePlateDrop.SetActive(true);
        }


    }

    private void OnTriggerExit(Collider collision)
    {


        if ((collision.CompareTag("Player") && gameObject.tag == "triggerFootStool") && GameObject.FindWithTag("footstool") != null)
        {
            activateFootstoolDrop.GetComponent<DropItemNactivate>().enabled = false;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerKey") && GameObject.FindWithTag("key") != null)
        {
            activateKeyDrop.GetComponent<DropItemNactivate>().enabled = false;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerDadmug") && GameObject.FindWithTag("dadmug") != null)
        {
            activateDadMugDrop.GetComponent<DropItemNactivate>().enabled = false;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMommug") && GameObject.FindWithTag("mommug") != null)
        {
            activateMomMugDrop.GetComponent<DropItemNactivate>().enabled = false;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMaymug") && GameObject.FindWithTag("maymug") != null)
        {
            activateMayMugDrop.GetComponent<DropItemNactivate>().enabled = false;
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerSpoon") && GameObject.FindWithTag("spoon") != null)
        {
            activateSpoonDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerPlate") && GameObject.FindWithTag("plate") != null)
        {
            activatePlateDrop.SetActive(false);
        }
    }
}
