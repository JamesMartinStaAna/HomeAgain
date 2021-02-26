using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItemNactivate : MonoBehaviour, IDropHandler
{

    public GameObject StoolActivate;
    public GameObject KitchenCabinetActivate;
    public GameObject KitchenCounterActivate;
    public GameObject BinActivate;
    public GameObject DadMugActivate;
    public GameObject MomMugActivate;
    public GameObject MayMugActivate;
    public GameObject spoonActivate;
    public GameObject plateActivate;
    public GameObject DestroyObject_bin;
    public GameObject DestroyObject_kitchen;
    public GameObject DestroyObject_kitchenCabinet;
    public GameObject deposit;

    bool StoolCheck;    
    bool KeyCheck;
    bool trashCheck;
    bool dadmugCheck;
    bool mommugCheck;
    bool maymugCheck;
    bool spoonCheck;
    bool plateCheck;


    public GameObject FootstoolObject;
    public GameObject kitchenCabinetObject;


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

        if (gameObject.tag == "spoon_receiver")
            if (invPanel.CompareTag("spoon"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    FootstoolObject.GetComponent<Collider>().enabled = true;
                    kitchenCabinetObject.GetComponent<Collider>().enabled = true;
                    spoonCheck = true;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "plate_receiver")
            if (invPanel.CompareTag("plate"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    plateCheck = true;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "dadmug_receiver")
            if (invPanel.CompareTag("dadmug"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    dadmugCheck = true;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "mommug_receiver")
            if (invPanel.CompareTag("mommug"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    mommugCheck = true;
                    Destroy(gameObject);



                }
            }

        if (gameObject.tag == "maymug_receiver")
            if (invPanel.CompareTag("maymug"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    maymugCheck = true;
                    Destroy(gameObject);



                }
            }


        if (gameObject.tag == "crumpledpaper_receiver")
            if (invPanel.CompareTag("crumpledpaper"))
            {
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    trashCheck = true;
                    Destroy(gameObject);



                }
            }
    }


    private void OnDestroy()
    {

        if (GameObject.FindWithTag("footstool_receiver") == null && StoolCheck == true)
        {
            StoolActivate.SetActive(true);
            KitchenCabinetActivate.SetActive(true);
            DestroyObject_kitchenCabinet.transform.position = deposit.transform.position;
            Debug.Log("Destroyed Footstool");

        }

        if (GameObject.FindWithTag("key_receiver") == null && KeyCheck == true)
        {
            KitchenCounterActivate.SetActive(true);
            DestroyObject_kitchen.transform.position = deposit.transform.position;
            Debug.Log("Destroyed key");
        }

        if (GameObject.FindWithTag("crumpledpaper_receiver") == null && trashCheck == true)
        {
            BinActivate.SetActive(true);
            Destroy(DestroyObject_bin);
            Debug.Log("Destroyed trash");
        }


        if (GameObject.FindWithTag("dadmug_receiver") == null && dadmugCheck == true)
        {
            DadMugActivate.SetActive(true);
        }

        if (GameObject.FindWithTag("mommug_receiver") == null && mommugCheck == true)
        {
            MomMugActivate.SetActive(true);
        }

        if (GameObject.FindWithTag("maymug_receiver") == null && maymugCheck == true)
        {
            MayMugActivate.SetActive(true);
        }


        if (GameObject.FindWithTag("spoon_receiver") == null && spoonCheck == true)
        {
            spoonActivate.SetActive(true);
        }


        if (GameObject.FindWithTag("plate_receiver") == null && plateCheck == true)
        {
            plateActivate.SetActive(true);
        }

    }


}
    