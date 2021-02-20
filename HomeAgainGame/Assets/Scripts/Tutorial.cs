using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider))]
public class Tutorial : MonoBehaviour
{
    Collider collision;
    public GameObject tutorial;
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


    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        //alphaLevel = 0;
        //sprite.color = new Color(1, 1, 1, alphaLevel);
        tutorial.SetActive(false);

        Debug.Log(collision.name + "Exit Tutorial");
    }
}