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

       for (int i = 0; i < inventory.slots.Length; i++){
          if (inventory.isFull[i] == false){
                //item can be added to inventory
                inventory.isFull[i] = true;
                Instantiate(itemButton, inventory.slots[i].transform, false);
                transform.position = deposit.transform.position;    
                
                //if (transform.position == deposit.transform.position)
                //{
                //    Destroy(gameObject);
                //}
                break;

          }
       }

           
        
    }
    public void Update()
    {
     
    }
}
