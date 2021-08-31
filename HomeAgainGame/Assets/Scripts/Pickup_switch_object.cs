using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_switch_object : Interactable
{
    private Inventory Inventory;
    public GameObject itemButton;
    public GameObject Deposit;
    public List<GameObject> gameActivate;
    public GameObject pickUpNotif;

    private void Start()
    {
        Inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public override void Interact()
    {
        SoundManager.PlaySound("popUp");


        for (int i = 0; i < Inventory.slots.Length; i++)
        {
            if (Inventory.isFull[i] == false)
            {
                //item can be added to inventory
                Inventory.isFull[i] = true;
                Instantiate(itemButton, Inventory.slots[i].transform, false);
                transform.position = Deposit.transform.position;

                // Activates certain object dialog/notif
                pickUpNotif.SetActive(true);


                if (gameActivate != null)
                {
                    foreach (GameObject obj in gameActivate)
                    {
                        obj.SetActive(true);
                    }
                }

                break;

            }
        }

    }

}
