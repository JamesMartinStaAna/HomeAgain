using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropItemNactivate2 : MonoBehaviour, IDropHandler
{
    private Inventory inventory;
    public GameObject itemButton;

    //Activate after box dropped
    public GameObject lockActive;

    //Activate after fullmoon dropped
    public GameObject chestActive;
    public GameObject chestInactive;

    //Deposit objects 
    public GameObject deposit;

    bool boxCheck;    
    bool lockCheck;
    bool moonCheck;





    //object highlights prologue
    public GameObject boxHighlight;
    public GameObject lockHighlight;
    public GameObject chestHighlight;


    private void Start()
    {
    
        boxHighlight = GameObject.Find("boxSparkle");
        lockHighlight = GameObject.Find("lockSparkle");
        chestHighlight = GameObject.Find("chestSparkle");



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

        if (gameObject.tag == "box_receiver")
            if (invPanel.CompareTag("boxItem"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    boxCheck = true;
                    Destroy(gameObject);

                }
            }


        if (gameObject.tag == "lockNkey_receiver")
            if (invPanel.CompareTag("lockNkey"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    lockCheck = true;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "blackMoon" || gameObject.tag == "whiteMoon")
            if (invPanel.CompareTag("whiteMoon") || invPanel.CompareTag("blackMoon"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "fullMoon_receiver")
            if (invPanel.CompareTag("fullMoon"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    moonCheck = true;
                    chestActive.SetActive(true);
                    chestInactive.transform.position = deposit.transform.position;
                    Destroy(gameObject);



                }
            }
    }


    private void OnDestroy()
    {

        if (GameObject.FindWithTag("box_receiver") == null && boxCheck == true)
        {
            lockActive.SetActive(true);
            boxHighlight.transform.position = deposit.transform.position;
            Debug.Log("Destroyed box");

        }

        if (GameObject.FindWithTag("lockNkey_receiver") == null && lockCheck == true)
        {
            lockHighlight.transform.position = deposit.transform.position;
            Debug.Log("Destroyed lock");
        }


        if (GameObject.FindWithTag("fullMoon_receiver") == null && moonCheck == true)
        {
            chestHighlight.transform.position = deposit.transform.position;
            Debug.Log("Destroyed moon");
        }

        if (GameObject.FindWithTag("blackMoon") == null && GameObject.FindWithTag("whiteMoon") == null && GameObject.Find("desk open") != null)
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
    