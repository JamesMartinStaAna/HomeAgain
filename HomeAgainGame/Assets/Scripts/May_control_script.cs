using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_control_script : MonoBehaviour
{
    public float MovementSpeed = 1;
    public Animator animator;

    private void Start()
    {
        
    }


    private void Update()
    {
        // Character Movement:
        var movement = Input.GetAxis("Horizontal");

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -6;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 6;
        }
        transform.localScale = characterScale;

        // Character Animation 
        animator.SetFloat("speed", Mathf.Abs(movement));
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
