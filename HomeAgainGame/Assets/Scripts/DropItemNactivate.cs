using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

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


    //object highlights prologue
    public GameObject binHighlight;
    public GameObject dadMugHighlight;
    public GameObject momMugHighlight;
    public GameObject mayMugHighlight;
    public GameObject spoonHighlight;
    public GameObject stoolHighlight;
    public GameObject plateHighlight;
    public GameObject kitchenKeyHighlight;

    private void Start()
    {
    
        binHighlight = GameObject.Find("trashSparkle");
        dadMugHighlight = GameObject.Find("dadMugSparkle");
        momMugHighlight = GameObject.Find("momMugSparkle");
        mayMugHighlight = GameObject.Find("mayMugSparkle");
        kitchenKeyHighlight = GameObject.Find("kitchenKeySparkle");
        spoonHighlight = GameObject.Find("spoonSparkle");
        stoolHighlight = GameObject.Find("stoolSparkle");
        plateHighlight = GameObject.Find("plateSparkle");

    
        
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
                    SoundManager.PlaySound("spoon");
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
                    SoundManager.PlaySound("mug");
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
                    SoundManager.PlaySound("mug");
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
                    SoundManager.PlaySound("mug");
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
                    SoundManager.PlaySound("mug");
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
                    SoundManager.PlaySound("trash");
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
            stoolHighlight.transform.position = deposit.transform.position;
            DestroyObject_kitchenCabinet.transform.position = deposit.transform.position;
            Debug.Log("Destroyed Footstool");

        }

        if (GameObject.FindWithTag("key_receiver") == null && KeyCheck == true)
        {
            KitchenCounterActivate.SetActive(true);
            DestroyObject_kitchen.transform.position = deposit.transform.position;
            kitchenKeyHighlight.transform.position = deposit.transform.position;
            Debug.Log("Destroyed key");
        }

        if (GameObject.FindWithTag("crumpledpaper_receiver") == null && trashCheck == true)
        {
            BinActivate.SetActive(true);
            Destroy(DestroyObject_bin);
            binHighlight.transform.position = deposit.transform.position;
            Debug.Log("Destroyed trash");
        }


        if (GameObject.FindWithTag("dadmug_receiver") == null && dadmugCheck == true)
        {
            DadMugActivate.SetActive(true);
            dadMugHighlight.transform.position = deposit.transform.position;
            Debug.Log("Spawn dadmug");
        }

        if (GameObject.FindWithTag("mommug_receiver") == null && mommugCheck == true)
        {
            MomMugActivate.SetActive(true);
            momMugHighlight.transform.position = deposit.transform.position;
            Debug.Log("Spawn mommug");
        }

        if (GameObject.FindWithTag("maymug_receiver") == null && maymugCheck == true)
        {
            MayMugActivate.SetActive(true);
            mayMugHighlight.transform.position = deposit.transform.position;
            Debug.Log("Spawn maymug");
        }


        if (GameObject.FindWithTag("spoon_receiver") == null && spoonCheck == true)
        {
            spoonActivate.SetActive(true);
            spoonHighlight.transform.position = deposit.transform.position;
            Debug.Log("Spawn spoon");
        }


        if (GameObject.FindWithTag("plate_receiver") == null && plateCheck == true)
        {
            plateActivate.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Spawn plate");
        }

    }


}
    