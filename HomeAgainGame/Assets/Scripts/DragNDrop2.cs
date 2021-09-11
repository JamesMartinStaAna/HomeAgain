using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;

  
    private bool isDragging;
    //chapt 1 highlight
    public GameObject boxHighlight;
    public SpriteRenderer boxHighlightsprite;
    public GameObject lockHighlight;
    public SpriteRenderer lockHighlightsprite;
    public GameObject chestHighlight;
    public SpriteRenderer chestHighlightsprite;
    public GameObject dollHighlight;
    public SpriteRenderer dollHighlightsprite;
    public GameObject letterHighlight;
    public SpriteRenderer letterHighlightsprite;




    private void Start()
    {
        
    }
    private void Awake()
    {
        //Box 
        boxHighlight = GameObject.Find("boxSparkle");
        boxHighlightsprite = boxHighlight.GetComponent<SpriteRenderer>();

        //Lock
        lockHighlight = GameObject.Find("lockSparkle");
        lockHighlightsprite = lockHighlight.GetComponent<SpriteRenderer>();

        //Chest
        chestHighlight = GameObject.Find("chestSparkle");
        chestHighlightsprite = chestHighlight.GetComponent<SpriteRenderer>();

        //doll on May
        dollHighlight = GameObject.Find("dollSparkle");
        dollHighlightsprite = dollHighlight.GetComponent<SpriteRenderer>();

        //lettr on May
        letterHighlight = GameObject.Find("letterSparkle");
        letterHighlightsprite = letterHighlight.GetComponent<SpriteRenderer>();


        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.localPosition;
        canvasGroup.blocksRaycasts = false;
        Debug.Log("begindrag Check");


    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;

        if(rectTransform.anchoredPosition == eventData.delta)
        {
            isDragging = true;
        }
         
    }

    public void OnEndDrag(PointerEventData eventData)
    {
            transform.localPosition = startPosition;
            canvasGroup.blocksRaycasts = true;
            isDragging = false;
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        SoundManager.PlaySound("click");
        Debug.Log("click Check");
    }

    private void Update()
    {
        if (isDragging)
        {
            if (gameObject.tag == "boxItem")
            {
                boxHighlightsprite.enabled = true;
                Debug.Log("is dragging box");
            }

            if (gameObject.tag == "lockNkey" && GameObject.Find("lock_Drop") != null)
            {
                lockHighlightsprite.enabled = true;
                Debug.Log("is dragging lockNkey");
            }

            if (gameObject.tag == "fullMoon")
            {
                chestHighlightsprite.enabled = true;
                Debug.Log("is dragging fullMoon");
            }

            if (gameObject.tag == "fixedDoll")
            {
                dollHighlightsprite.enabled = true;
                Debug.Log("is dragging doll");
            }

            if (gameObject.tag == "letter")
            {
                letterHighlightsprite.enabled = true;
                Debug.Log("is dragging letter");
            }
        }

        if (!isDragging)
        {
            if (gameObject.tag == "boxItem")
            {
                boxHighlightsprite.enabled = false;
            }

            if (gameObject.tag == "lockNkey" && GameObject.Find("lock_Drop") != null)
            {
                lockHighlightsprite.enabled = false;
            }

            if (gameObject.tag == "fullMoon")
            {
                chestHighlightsprite.enabled = false;
         
            }

            if (gameObject.tag == "fixedDoll")
            {
                dollHighlightsprite.enabled = false;

            }

            if (gameObject.tag == "letter")
            {
                letterHighlightsprite.enabled = false;

            }
        }

    }

}
