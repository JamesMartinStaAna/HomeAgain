using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Sprite_Change_cause : MonoBehaviour
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
        if (GameObject.FindWithTag("May_room_light") != null)
        {
            sr.sprite = active;
        }
        else
        {
            sr.sprite = inactive;

        }
       
    }
}
