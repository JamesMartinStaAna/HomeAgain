using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollBehavior : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Awake()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void OnDestroy()
    {
        if (GameObject.FindWithTag("doll_receiver") == null)
        {
            SoundManager.PlaySound("popUp");
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    break;

                }
            }



        }

    }
}
