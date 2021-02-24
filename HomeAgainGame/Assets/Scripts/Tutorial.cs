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
    float alphaLevel;
    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void Reset()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && gameObject.tag == "view")
        
            Interact.SetActive(true); 
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(Movement);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Player") && gameObject.tag == "view")
        {
            Destroy(Interact);
            Destroy(gameObject);
        }

        Debug.Log(collision.name + "Exit Tutorial");
    }
}