using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_SpriteChange : MonoBehaviour
{
    public Sprite active;
    public Sprite inactive;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = inactive;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("May_room_light") != null && gameObject.tag == "May_room_lightbulb")
        {
            sr.sprite = active;
        }

        else if (GameObject.FindWithTag("MB_room_light") != null && gameObject.tag == "MB_room_lightbulb")
        {
            sr.sprite = active;
        }

        else if (GameObject.FindWithTag("kitchen_light") != null && gameObject.tag == "kitchen_lightbulb")
        {
            sr.sprite = active;

        }
        else if (GameObject.FindWithTag("living_room_light") != null && gameObject.tag == "livingroom_lightbulb")
        {
            sr.sprite = active;
        }

        else if (GameObject.FindWithTag("stair_way_light") != null && gameObject.tag == "stairway_lightbulb")
        {
            sr.sprite = active;
        }
     
        else
        {
            sr.sprite = inactive;

        }

    }
}

