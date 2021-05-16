using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_Object : Interactable
{
    private Inventory inventory;
    public GameObject deposit;
    public GameObject gameActivate;
    public GameObject pickUpNotif;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public override void Interact()
    {
        SoundManager.PlaySound("popUp");

        if (inventory.CompareTag("Player") && gameObject.tag == "grab_object")
        {
            transform.position = deposit.transform.position;
            pickUpNotif.SetActive(true);
            gameActivate.SetActive(true);
          
        }
    }

}
