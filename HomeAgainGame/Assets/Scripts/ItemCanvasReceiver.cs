using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ItemCanvasReceiver : MonoBehaviour, IDropHandler
{
    public List<string> ReceivableItems;
    public GameObject Deposit;
    public List<GameObject> WorldObjectsToActivate;
    public List<GameObject> WorldObjectsToDeposit;
    public UnityEvent Callback;
    public AudioSource SoundClip;
    
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform draggedObject = eventData.pointerDrag.GetComponent<RectTransform>();

        Debug.Log(draggedObject);
        Debug.Log(gameObject.GetComponent<RectTransform>());

        // Check if the draggedObject is valid
        DragObject draggableObjectComponent = draggedObject.GetComponent<DragObject>();
        if (draggableObjectComponent != null)
        {
            // Check if the id is valid
            if (ReceivableItems.Contains(draggableObjectComponent.ObjectId))
            {
                Debug.Log("Pointer drop detected");
                // Mechanic done succesfully
                if (eventData.pointerDrag != null)
                {
                    RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                    Rect.SetParent(transform, false);
                    Rect.transform.position = transform.position;
                    if (SoundClip != null)
                    {
                        SoundClip.Play();
                    }


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


}