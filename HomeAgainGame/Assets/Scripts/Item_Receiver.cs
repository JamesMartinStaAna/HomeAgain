using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Item_Receiver : MonoBehaviour, IDropHandler
{
    public string Name;
    public GameObject HighlightRemove;
    public GameObject WorldObjectToRemove;
    public GameObject WorldObjectToSwap;
    public GameObject deposit;

    bool StoolCheck;
    bool KeyCheck;
    bool trashCheck;
    bool dadmugCheck;
    bool mommugCheck;
    bool maymugCheck;
    bool spoonCheck;
    bool plateCheck;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        RectTransform invPanel = eventData.pointerDrag.GetComponent<RectTransform>();



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
                    spoonCheck = true;
                    SoundManager.PlaySound("spoon");
                    Destroy(gameObject);



                }
            }

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

    }

    private void OnDestroy()
    {


        if (GameObject.FindWithTag("crumpledpaper_receiver") == null && trashCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            WorldObjectToRemove.transform.position = deposit.transform.position;
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Destroyed trash");
        }


        if (GameObject.FindWithTag("dadmug_receiver") == null && dadmugCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Spawn dadmug");
        }

        if (GameObject.FindWithTag("mommug_receiver") == null && mommugCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Spawn mommug");
        }

        if (GameObject.FindWithTag("maymug_receiver") == null && maymugCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Spawn maymug");
        }

        if (GameObject.FindWithTag("key_receiver") == null && KeyCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            WorldObjectToRemove.transform.position = deposit.transform.position;
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Destroyed key");
        }

        if (GameObject.FindWithTag("spoon_receiver") == null && spoonCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            HighlightRemove.transform.position = deposit.transform.position;
            Debug.Log("Spawn spoon");
        }


        if (GameObject.FindWithTag("footstool_receiver") == null && StoolCheck == true)
        {
            WorldObjectToSwap.SetActive(true);
            HighlightRemove.transform.position = deposit.transform.position;

            Debug.Log("Destroyed Footstool");

        }

        if (GameObject.FindWithTag("plate_receiver") == null && plateCheck == true)
        {

            WorldObjectToSwap.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Spawn plate");
        }



    }

}
