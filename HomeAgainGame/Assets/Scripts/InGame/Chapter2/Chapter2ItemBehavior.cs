using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2ItemBehavior : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    
    private void Awake()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    public void GetItem()
    {

        SoundManager.PlaySound("popUp");
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            
            if (inventory.isFull[i] == false)
            {
                //item can be added to inventory
                Instantiate(itemButton, inventory.slots[i].transform, false);
                inventory.isFull[i] = true;
                break;

            }
        }


    }
}
