using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItemBehavior : MonoBehaviour
{
    private Inventory inventory;
    public List <GameObject> itemButton;

    
    private void Awake()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    public void OnDestroy()
    {
        foreach (GameObject obj in itemButton)
        {
            SoundManager.PlaySound("popUp");
            for (int i = 0; i < inventory.slots.Length; i++)
            {

                if (inventory.isFull[i] == false)
                {
                    //item can be added to inventory
                    Instantiate(obj, inventory.slots[i].transform, false);
                    inventory.isFull[i] = true;
                    break;

                }
            }
        }



    }
}
