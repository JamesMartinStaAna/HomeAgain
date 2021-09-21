﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : Interactable
{
    private Inventory inventory;
    public GameObject ItemButton;
    public GameObject Deposit;
    public List<GameObject> ObjectsToActivate;
    public List<GameObject> ObjectsToDeposit;
    public GameObject PickUpNotif;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public override void Interact()
    {
        SoundManager.PlaySound("popUp");


        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {
                //item can be added to inventory
                inventory.isFull[i] = true;
                Instantiate(ItemButton, inventory.slots[i].transform, false);
                transform.position = Deposit.transform.position;

                // Activates certain object dialog/notif
                PickUpNotif.SetActive(true);


                if (ObjectsToActivate != null)
                {
                    foreach (GameObject obj in ObjectsToActivate)
                    {
                        obj.SetActive(true);
                    }
                }

                if (ObjectsToDeposit != null)
                {
                    foreach (GameObject obj in ObjectsToDeposit)
                    {
                        obj.transform.position = Deposit.transform.position;
                    }
                }

                break;

            }
        }

    }

}