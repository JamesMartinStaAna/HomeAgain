using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider))]
public class Tutorial : MonoBehaviour
{
    Collider collision;
    public GameObject Movement;
    public GameObject Interact;
    public GameObject Inventory;

    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (GameObject.Find("crumpledpaper_small").transform.position == GameObject.Find("Deposit").transform.position && GameObject.Find("crumpledpaper_notif") == null)
        {
            Inventory.SetActive(true);
        }


        if (Inventory.activeSelf && Input.GetMouseButtonDown(0))
        {
            Destroy(Inventory);
            Destroy(gameObject);
        }

        if (Interact.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            Interact.SetActive(false);
            Destroy(GameObject.Find("_Interact"));
        }

    }

    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && gameObject.tag == "view" && GameObject.Find("Inventory Function")==null)
        {
            Interact.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(Movement);
  
        }

        if (collision.CompareTag("Player") && gameObject.tag == "view" && GameObject.Find("Inventory Function") == null)
        {
            Interact.SetActive(false);
        }



        Debug.Log(collision.name + "Exit Tutorial");
    }
}