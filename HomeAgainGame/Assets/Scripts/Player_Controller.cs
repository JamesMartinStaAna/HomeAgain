using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float MovementSpeed = 1;
    public Animator animator;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        // Character Movement:
        var movement = Input.GetAxis("Horizontal");

        if (Input.GetAxis("Horizontal") < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }



        // Character Animation 
        animator.SetFloat("speed", Mathf.Abs(movement));
        rb.velocity = new Vector3(movement, 0, 0) * MovementSpeed;


    }
}
