using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_control_script : MonoBehaviour
{
    //Movement Elements
    private float MovementSpeed = 4;
    Rigidbody rb;
    AudioSource audioSrc;
    bool isMoving = false;

    //Icon Notifs
    public GameObject interactIcon;
    public GameObject interactIcon_Light;
    public GameObject interactIcon_Door;
    public GameObject interactIcon_Stairs;
    public GameObject interactIcon_GrabObject;
    public GameObject interactIcon_To_Lobby;
    public GameObject interactIcon_To_LivingRoom;
    public GameObject interactIcon_Task;

    //Animations
    private bool animateMove;
    public Animator animator;

    //Inventory
    private bool InvenisActive;
    public Animator Invenanimator;

    private Vector3 boxSize = new Vector3(0.1f, 1f, 1f);

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSrc = GetComponent<AudioSource>();
   
    }


    private void Update()
    {
        
    

        // Character Interact:
        if (Input.GetKeyDown(KeyCode.E) && rb.velocity.magnitude == 0)
        {
            CheckInteraction();
        }

        ViewStop();
        


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

        // Character walk sound 
        if (rb.velocity.x != 0)
            isMoving = true;
        else
            isMoving = false;

        if (isMoving)
        {
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else
        {
            audioSrc.Stop();
        }


    }
    private void ViewStop()
    {

        if (GameObject.FindWithTag("open_image") != null || GameObject.FindWithTag("reminder") != null)
        {
            MovementSpeed = 0;
            animator.enabled = false;
            animateMove = false;
        }
        else
        {
            MovementSpeed = 4;
            animator.enabled = true;
            animateMove = true;
        }
    }
    // for checking boxcast 
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

    public void OpenInteractableIconToLobby()
    {
        interactIcon_To_Lobby.SetActive(true);

    }

    public void CloseInteractableIconToLobby()
    {
        interactIcon_To_Lobby.SetActive(false);

    }

    public void OpenInteractableIconToLivingRoom()
    {
        interactIcon_To_LivingRoom.SetActive(true);

    }

    public void CloseInteractableIconToLivingRoom()

    {
        interactIcon_To_LivingRoom.SetActive(false);

    }


    public void OpenInteractableIcongrab()
    {
        interactIcon_GrabObject.SetActive(true);

    }

    public void CloseInteractableIcongrab()

    {
        interactIcon_GrabObject.SetActive(false);

    }


    public void OpenInteractableIconTask()
    {
        interactIcon_Task.SetActive(true);

    }

    public void CloseInteractableIconTask()

    {
        interactIcon_Task.SetActive(false);

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
