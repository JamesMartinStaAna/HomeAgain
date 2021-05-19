using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropItemNactivate2c : MonoBehaviour, IDropHandler
{
    private Inventory inventory;
    public GameObject itemButton;

    //Deposit objects 
    public GameObject deposit;

    public GameObject letterHighlight;
    public GameObject end;
    bool letterCheck;





    private void Start()
    {
        letterHighlight = GameObject.Find("dollSparkle");


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


        if (gameObject.tag == "letter_receiver")
            if (invPanel.CompareTag("letter"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    letterCheck = true;
                    letterHighlight.transform.position = deposit.transform.position;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "silverBox" || gameObject.tag == "silverKey")
            if (invPanel.CompareTag("silverBox") || invPanel.CompareTag("silverKey"))
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

        if (GameObject.FindWithTag("letter") == null && letterCheck == true)
        {
            end.SetActive(true);
            Debug.Log("Spawn plate");
        }


        if (GameObject.FindWithTag("silverBox") == null && GameObject.FindWithTag("silverKey") == null && GameObject.Find("Tresure Chest open") != null)
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
    