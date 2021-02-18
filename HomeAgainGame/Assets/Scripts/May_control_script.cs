using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_control_script : MonoBehaviour
{
    private float MovementSpeed = 5;
    public Animator animator;
    public GameObject interactIcon;
    public GameObject interactIcon_Light;
    public GameObject interactIcon_Door;
    public GameObject interactIcon_Stairs;
    public GameObject interactIcon_GrabObject;

    public GameObject pauseMenu;
    private bool animateMove;

    Rigidbody rb;
 

    private Vector3 boxSize = new Vector3(0.1f, 1f, 1f);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
   
    }


    private void Update()
    {

        if (GameObject.FindWithTag("open_image") != null)
        {
            MovementSpeed = MovementSpeed - MovementSpeed;
            animator.enabled = false;
            animateMove = false;
        }
        else
        {
            MovementSpeed = 5;
            animator.enabled = true;
            animateMove = true;
        }
    

        // Character Interact:
        if (Input.GetKeyDown(KeyCode.E) && rb.velocity.magnitude == 0)
        {
            CheckInteraction();
        }


        //Pause Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
  


        // Character Movement:
        var movement = Input.GetAxis("Horizontal");

        if(animateMove == true)
        {

            if (Input.GetAxis("Horizontal") < 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
        }



        // Character Animation                                          

        animator.SetFloat("speed", Mathf.Abs(movement));
        rb.velocity = new Vector3(movement, 0, 0) * MovementSpeed;




    }
    // for checking boxcast 
    void OnDrawGizmos()
    {
        float maxDistance = 1f;
        RaycastHit hit;

        bool isHit = Physics.BoxCast(transform.position, transform.lossyScale, transform.forward, out hit,
            transform.rotation, maxDistance);
        if (isHit)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
            Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.lossyScale);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, transform.forward * maxDistance);
        }
    }

    public void OpenInteractableIcon()
    {
        interactIcon.SetActive(true);

    }

    public void CloseInteractableIcon()
    {
        interactIcon.SetActive(false);

    }

    public void OpenInteractableIconlight()
    {
        interactIcon_Light.SetActive(true);

    }

    public void CloseInteractableIconlight()
    {
        interactIcon_Light.SetActive(false);

    }

    public void OpenInteractableIcondoor()
    {
        interactIcon_Door.SetActive(true);

    }

    public void CloseInteractableIcondoor()
    {
        interactIcon_Door.SetActive(false);

    }

    public void OpenInteractableIconstairs()
    {
        interactIcon_Stairs.SetActive(true);

    }

    public void CloseInteractableIconstairs()
    {
        interactIcon_Stairs.SetActive(false);

    }

    public void OpenInteractableIcongrab()
    {
        interactIcon_GrabObject.SetActive(true);

    }

    public void CloseInteractableIcongrab()
    {
        interactIcon_GrabObject.SetActive(false);

    }


    public void Pause()
    {
        pauseMenu.SetActive(true);

    }

    private void CheckInteraction()
    {
       
        RaycastHit[] hits = Physics.BoxCastAll(transform.position, transform.lossyScale / 8f, transform.forward, transform.rotation);


        if (hits.Length > 0 )

        {
            foreach (RaycastHit rc in hits )
          
            {
                if (rc.transform.GetComponent<Interactable>() )
                {
                    Debug.Log("Did Hit");
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;

                }
            }
        }
    }

}
