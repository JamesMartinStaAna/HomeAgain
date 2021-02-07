using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_control_script : MonoBehaviour
{
    public float MovementSpeed = 1;
    public Animator animator;
    public GameObject interactIcon;
 

    private Vector3 boxSize = new Vector3(0.1f, 1f, 1f);

    private void Start()
    {
   
    }


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
            CheckInteraction();


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
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

   
  
    }
    //// for checking boxcast 
    //void OnDrawGizmos()
    //{
    //    float maxDistance = 1f;
    //    RaycastHit hit;

    //    bool isHit = Physics.BoxCast(transform.position, transform.lossyScale, transform.forward, out hit,
    //        transform.rotation, maxDistance);
    //    if (isHit)
    //    {
    //        Gizmos.color = Color.red;
    //        Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
    //        Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.lossyScale);
    //    }
    //    else
    //    {
    //        Gizmos.color = Color.green;
    //        Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
    //    }
    //}

    public void OpenInteractableIcon()
    {
        interactIcon.SetActive(true);

    }

    public void CloseInteractableIcon()
    {
        interactIcon.SetActive(false);

    }

    private void CheckInteraction()
    {
       
        RaycastHit[] hits = Physics.BoxCastAll(transform.position, transform.lossyScale / 8f, transform.forward, transform.rotation);


        if (hits.Length > 0)

        {
            foreach (RaycastHit rc in hits)
          
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    Debug.Log("Did Hit");
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;

                }
            }
        }
    }
}
