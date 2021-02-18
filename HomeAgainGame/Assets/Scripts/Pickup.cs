using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    private Inventory inventory;
    public GameObject itemButton;


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
                Destroy(gameObject);         
                break;

          }
       }

           
        
    }
    public void OnDestroy()
    {
       GetComponent<May_control_script>().OpenInteractableIcongrab();
       Debug.Log("Picked");
    }
}
