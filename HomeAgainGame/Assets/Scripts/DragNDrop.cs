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


    private void Awake()
    {
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
        Debug.Log("drag Check");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // check if the card has been placed in a slot
        DropItemNactivate slot = GetComponentInParent<DropItemNactivate>();
        if (!slot)
        {
            transform.localPosition = startPosition;
            canvasGroup.blocksRaycasts = true;
            Instantiate(remind);
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("click Check");
    }

}
