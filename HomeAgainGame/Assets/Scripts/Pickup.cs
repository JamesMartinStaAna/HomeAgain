using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject deposit;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    public override void Interact(){

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

                    break;

                }
            }
        }


           
        
    }
    public void Update()
    {
     
    }
}
