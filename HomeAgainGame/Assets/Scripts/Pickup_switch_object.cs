using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_switch_object : Interactable
{
    private Inventory inventory;
    public GameObject itemButton;
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
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    transform.position = deposit.transform.position;
                    pickUpNotif.SetActive(true);
                    if (gameActivate != null)
                    {
                        gameActivate.SetActive(true);
                    }
                    
                    break;

                }
            }
        }
    }

}
