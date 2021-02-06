using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_Mouse_control : MonoBehaviour
{
    private Vector2 target;
 
    void Start()
    {
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0)) 
        {
            target = new Vector3(mousePos.x, transform.position.y, transform.position.z);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }

}