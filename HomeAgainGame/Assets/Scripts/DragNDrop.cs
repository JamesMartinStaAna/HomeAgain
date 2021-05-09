using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;
    public GameObject remind;

  
    private bool isDragging;
    //Prologue Notif objects
    public GameObject binHighlight;
    public SpriteRenderer binHighlightsprite;


    private void Start()
    {
        
    }
    private void Awake()
    {
        binHighlight = GameObject.Find("testhigh");
        binHighlightsprite = binHighlight.GetComponent<SpriteRenderer>();

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
        // check if the card has been placed in a slot
        DropItemNactivate slot = GetComponentInParent<DropItemNactivate>();
        if (!slot)
        {
            transform.localPosition = startPosition;
            canvasGroup.blocksRaycasts = true;
            isDragging = false;
            Instantiate(remind);
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        SoundManager.PlaySound("click");
        Debug.Log("click Check");
    }

    private void Update()
    {
        if (gameObject.tag == "crumpledpaper" && isDragging)
        {
            binHighlightsprite.enabled = true;
            Debug.Log("is dragging paper");

        }
        else
        {
            binHighlightsprite.enabled = false;
        }

    }

}
