using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropItemNactivate2a : MonoBehaviour, IDropHandler
{
    private Inventory inventory;
    public GameObject itemButton;

    //Deposit objects 
    public GameObject deposit;



    private void Start()
    {
    



    }
    private void Awake()
    {
        
        deposit = GameObject.Find("Deposit");
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        RectTransform invPanel = eventData.pointerDrag.GetComponent<RectTransform>();

   


        if (gameObject.tag == "brokenDoll" || gameObject.tag == "brokenDollArm")
            if (invPanel.CompareTag("brokenDoll") || invPanel.CompareTag("brokenDollArm"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    Destroy(gameObject);



                }
            }
    }


    private void OnDestroy()
    {
        if (GameObject.FindWithTag("brokenDoll") == null && GameObject.FindWithTag("brokenDollArm") == null && GameObject.Find("Tresure Chest open") != null)
        {
            SoundManager.PlaySound("popUp");

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    break;

                }
            }
        }

    }


}
    