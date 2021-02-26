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

    private void OnTriggerEnter(Collider collision)
    {
        if ((collision.CompareTag("Player") && gameObject.tag == "triggerFootStool") && GameObject.FindWithTag("footstool") != null)
        {
            activateFootstoolDrop.SetActive(true);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerKey") && GameObject.FindWithTag("key") != null)
        {
            activateKeyDrop.SetActive(true);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerDadmug") && GameObject.FindWithTag("dadmug") != null)
        {
            activateDadMugDrop.SetActive(true);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMommug") && GameObject.FindWithTag("mommug") != null)
        {
            activateMomMugDrop.SetActive(true);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMaymug") && GameObject.FindWithTag("maymug") != null)
        {
            activateMayMugDrop.SetActive(true);
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
            activateFootstoolDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerKey") && GameObject.FindWithTag("key") != null)
        {
            activateKeyDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerDadmug") && GameObject.FindWithTag("dadmug") != null)
        {
            activateDadMugDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMommug") && GameObject.FindWithTag("mommug") != null)
        {
            activateMomMugDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerMaymug") && GameObject.FindWithTag("maymug") != null)
        {
            activateMayMugDrop.SetActive(false);
        }

        if ((collision.CompareTag("Player") && gameObject.tag == "triggerPlate") && GameObject.FindWithTag("plate") != null)
        {
            activatePlateDrop.SetActive(false);
        }
    }
}
