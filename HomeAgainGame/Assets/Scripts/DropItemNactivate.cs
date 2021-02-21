using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropItemNactivate : MonoBehaviour, IDropHandler
{

    public GameObject gameActivate;


    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        RectTransform invPanel = eventData.pointerDrag.GetComponent<RectTransform>();

        if (invPanel.CompareTag("footstool"))
        {
            if (eventData.pointerDrag != null)
            {
                RectTransform Rect = eventData.pointerDrag.GetComponent<RectTransform>();
                Rect.SetParent(transform, false);
                Rect.transform.position = transform.position;
                Destroy(gameObject);
            }
        }

    }
    void OnDestroy()
    {
        if (GameObject.FindWithTag("footstool") == null)
        {
            gameActivate.SetActive(true);
            Debug.Log("Destroyed");
        }
    
    }
}
    