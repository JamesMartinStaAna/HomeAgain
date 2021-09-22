using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DropTriggerCheck : MonoBehaviour
{

    public GameObject ActivateDrop;
    public string DraggedObjectId;


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
        if (ActivateDrop != null)
        {
            // checks if player is withing certain trigger holding their matching objects]
            if (collision.CompareTag("Player") && GameObject.FindWithTag(DraggedObjectId) != null)
            {
                ActivateDrop.GetComponent<ItemCanvasReceiver>().enabled = true;
            }


        }

    }

    private void OnTriggerExit(Collider collision)
    {

        if (ActivateDrop != null)
        {

            if (collision.CompareTag("Player") && GameObject.FindWithTag(DraggedObjectId) != null)
            {
                ActivateDrop.GetComponent<ItemCanvasReceiver>().enabled = false;
            }

            
        }
    }
}
