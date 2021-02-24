using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItemNactivate : MonoBehaviour, IDropHandler
{

    public GameObject StoolActivate;
    public GameObject KitchenCounterActivate;
    public GameObject DestroyObject_kitchen;
    public GameObject deposit;

    bool StoolCheck;
    bool KeyCheck;

    private void Start()
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        RectTransform invPanel = eventData.pointerDrag.GetComponent<RectTransform>();

        if (gameObject.tag == "footstool_receiver")
            if (invPanel.CompareTag("footstool"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    StoolCheck = true;
                    Destroy(gameObject);

                }
            }


        if (gameObject.tag == "key_receiver")
            if (invPanel.CompareTag("key"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    KeyCheck = true;
                    Destroy(gameObject);



                }
            }


    }


    private void OnDestroy()
    {

        if (GameObject.FindWithTag("footstool_receiver") == null && StoolCheck == true)
        {
            StoolActivate.SetActive(true);
            Debug.Log("Destroyed Footstool");

        }

        if (GameObject.FindWithTag("key_receiver") == null && KeyCheck == true)
        {
            KitchenCounterActivate.SetActive(true);
            DestroyObject_kitchen.transform.position = deposit.transform.position;
            Debug.Log("Destroyed key");
        }


    }


}
    