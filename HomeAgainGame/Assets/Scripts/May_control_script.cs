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
        var movement = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(movement));
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
