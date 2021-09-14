using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;


  
    private bool isDragging;
    //Highlights of objects
    public string ObjectHighlightName;
    private GameObject objectHighlight;
    private SpriteRenderer objectHighlightSprite;

    //Draggable Dragged Object Id
    public string ObjectId;


    private void Start()
    {
        
    }
    private void Awake()
    {
        objectHighlight = GameObject.Find(ObjectHighlightName);
        objectHighlightSprite = objectHighlight.GetComponent<SpriteRenderer>();

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
        //Activate HighLight
        if (isDragging)
        {
            objectHighlightSprite.enabled = true;
        }

        //DeActivate HighLight
        if (!isDragging)
        {
            objectHighlightSprite.enabled = false;
        }

    }

}
