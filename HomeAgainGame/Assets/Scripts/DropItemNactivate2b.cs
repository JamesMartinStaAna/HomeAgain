using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DropItemNactivate2b : MonoBehaviour, IDropHandler
{
    private Inventory inventory;
    public GameObject itemButton;

    //Deposit objects 
    public GameObject deposit;


    public GameObject dollHighlight;
    public GameObject silverKeyView;

    bool dollCheck;

    private void Start()
    {
        dollHighlight = GameObject.Find("dollSparkle");


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




        if (gameObject.tag == "doll_receiver")
            if (invPanel.CompareTag("fixedDoll"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    dollCheck = true;
                    silverKeyView.SetActive(true);
                    Destroy(gameObject);



                }
            }
    }


    private void OnDestroy()
    {



        if (GameObject.FindWithTag("doll_receiver") == null && dollCheck == true)
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
    