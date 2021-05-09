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
    //Prologue highlight objects
    public GameObject binHighlight;
    public SpriteRenderer binHighlightsprite;
    public GameObject dadMugHighlight;
    public SpriteRenderer dadMugHighlightsprite;
    public GameObject momMugHighlight;
    public SpriteRenderer momMugHighlightsprite;
    public GameObject mayMugHighlight;
    public SpriteRenderer mayMugHighlightsprite;
    public GameObject kitchenKeyHighlight;
    public SpriteRenderer kitchenKeyHighlightsprite;




    private void Start()
    {
        
    }
    private void Awake()
    {
        //bin
        binHighlight = GameObject.Find("trashSparkle");
        binHighlightsprite = binHighlight.GetComponent<SpriteRenderer>();

        //dadmug
        dadMugHighlight = GameObject.Find("dadMugSparkle");
        dadMugHighlightsprite = dadMugHighlight.GetComponent<SpriteRenderer>();

        //mommug
        momMugHighlight = GameObject.Find("momMugSparkle");
        momMugHighlightsprite = momMugHighlight.GetComponent<SpriteRenderer>();

        //maymug
        mayMugHighlight = GameObject.Find("mayMugSparkle");
        mayMugHighlightsprite = mayMugHighlight.GetComponent<SpriteRenderer>();

        //kitchenkey
        kitchenKeyHighlight = GameObject.Find("kitchenKeySparkle");
        kitchenKeyHighlightsprite = kitchenKeyHighlight.GetComponent<SpriteRenderer>();

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
        else if (gameObject.tag == "dadmug" && isDragging)
        {
            dadMugHighlightsprite.enabled = true;
            Debug.Log("is dragging dadmug");
        }
        else if (gameObject.tag == "mommug" && isDragging)
        {
            momMugHighlightsprite.enabled = true;
            Debug.Log("is dragging mommug");
        }
        else if (gameObject.tag == "maymug" && isDragging)
        {
            mayMugHighlightsprite.enabled = true;
            Debug.Log("is dragging maymug");
        }
        else if (gameObject.tag == "key" && isDragging)
        {
            kitchenKeyHighlightsprite.enabled = true;
            Debug.Log("is dragging key");
        }
        else
        {
            binHighlightsprite.enabled = false;
        }

    }

}
