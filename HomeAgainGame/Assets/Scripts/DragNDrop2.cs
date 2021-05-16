﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDrop2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler 
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector3 startPosition;
    public GameObject remind;

  
    private bool isDragging;
    //chapt 1 highlight
    public GameObject boxHighlight;
    public SpriteRenderer boxHighlightsprite;
    public GameObject lockHighlight;
    public SpriteRenderer lockHighlightsprite;
 




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
        if (isDragging)
        {
            if (gameObject.tag == "boxItem")
            {
                boxHighlightsprite.enabled = true;
                Debug.Log("is dragging box");
            }

            if (gameObject.tag == "lockNkey")
            {
                lockHighlightsprite.enabled = true;
                Debug.Log("is dragging lockNkey");
            }


        }

        if (!isDragging)
        {
            if (gameObject.tag == "boxItem")
            {
                boxHighlightsprite.enabled = false;
            }

            if (gameObject.tag == "lockNkey")
            {
                lockHighlightsprite.enabled = false;
            }

    
        }

    }

}
