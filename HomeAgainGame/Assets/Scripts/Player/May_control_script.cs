using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class May_control_script : MonoBehaviour
{
    //Movement Elements 
    private float movementspeed = 6;
    Rigidbody Rb;
    AudioSource AudioSrc;
    bool IsMoving = false;

    //Icons
    [Header("Player Icons")]
    public List <GameObject> InteractIcon;
 

    //Animations
    private bool AnimateMove;
    public Animator animator;

    //Inventory
    private bool InvenisActive;
    public Animator Invenanimator;

    private Vector3 boxSize = new Vector3(0.1f, 1f, 1f);

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
        AudioSrc = GetComponent<AudioSource>();
   
    }


    private void Update()
    {
        
    

        // Character Interact:
        if (Input.GetKeyDown(KeyCode.E) && Rb.velocity.magnitude == 0 && GameObject.FindWithTag("open_image") == null)
        {
            CheckInteraction();
        }
        
        ViewStop();
        
        // Character Movement:
        var movement = Input.GetAxis("Horizontal");

        // Character Flip direction
        if (AnimateMove == true)
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
        Rb.velocity = new Vector3(movement, 0, 0) * movementspeed;

        // Character walk sound 
        if (Rb.velocity.x != 0)
            IsMoving = true;
        else
            IsMoving = false;

        if (IsMoving)
        {
            if (!AudioSrc.isPlaying)
                AudioSrc.Play();
        }
        else
        {
            AudioSrc.Stop();
        }


    }
    private void ViewStop()
    {

        if (GameObject.FindWithTag("open_image") != null || GameObject.FindWithTag("reminder") != null)
        {
            movementspeed = 0;
            animator.enabled = false;
            AnimateMove = false;
        }
        else
        {
            movementspeed = 6;
            animator.enabled = true;
            AnimateMove = true;
        }
    }

    public void OpenInteractableIcon()
    {
        InteractIcon[0].SetActive(true);

    }

    public void CloseInteractableIcon()
    {
        InteractIcon[0].SetActive(false);

    }

    public void OpenInteractableIconlight()
    {
        InteractIcon[1].SetActive(true);

    }

    public void CloseInteractableIconlight()
    {
        InteractIcon[1].SetActive(false);

    }

    public void OpenInteractableIcondoor()
    {
        InteractIcon[2].SetActive(true);

    }

    public void CloseInteractableIcondoor()
    {
        InteractIcon[2].SetActive(false);

    }

    public void OpenInteractableIconstairs()
    {
        InteractIcon[3].SetActive(true);

    }

    public void CloseInteractableIconstairs()
    {
        InteractIcon[3].SetActive(false);

    }

    public void OpenInteractableIconToLobby()
    {
        InteractIcon[4].SetActive(true);

    }

    public void CloseInteractableIconToLobby()
    {
        InteractIcon[4].SetActive(false);

    }

    public void OpenInteractableIconToLivingRoom()
    {
        InteractIcon[5].SetActive(true);

    }

    public void CloseInteractableIconToLivingRoom()

    {
        InteractIcon[5].SetActive(false);

    }


    public void OpenInteractableIcongrab()
    {
        InteractIcon[6].SetActive(true);

    }

    public void CloseInteractableIcongrab()

    {
        InteractIcon[6].SetActive(false);

    }


    public void OpenInteractableIconTask()
    {
        InteractIcon[7].SetActive(true);

    }

    public void CloseInteractableIconTask()

    {
        InteractIcon[7].SetActive(false);

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
