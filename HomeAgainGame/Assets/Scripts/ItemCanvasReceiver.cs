using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ItemCanvasReceiver : MonoBehaviour, IDropHandler
{
    public GameObject Deposit;
    public List<GameObject> WorldObjectsToActivate;
    public List<GameObject> WorldObjectsToDeposit;
    public UnityEvent Callback;
    
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
        RectTransform invPanel = eventData.pointerDrag.GetComponent<RectTransform>();

        Debug.Log(invPanel);
        Debug.Log(gameObject.GetComponent<RectTransform>());
        // Check if the mouse pointer drag-and-dropped to this object
        if (invPanel = gameObject.GetComponent<RectTransform>())
        {
            Debug.Log("Pointer drop detected");
            // Mechanic done succesfully
            if (eventData.pointerDrag != null)
            {
                RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                Rect.SetParent(transform, false);
                Rect.transform.position = transform.position;
                
                // Activate world objects
                foreach (GameObject obj in WorldObjectsToActivate)
                {
                    obj.SetActive(true);
                }

                // Move unneeded objects to deposit
                foreach (GameObject obj in WorldObjectsToDeposit)
                {
                    obj.transform.position = Deposit.transform.position;
                }

                // If there's a special behavior, invoke it
                if (Callback != null) Callback.Invoke();

                Destroy(gameObject);
            }
        }

    }

}