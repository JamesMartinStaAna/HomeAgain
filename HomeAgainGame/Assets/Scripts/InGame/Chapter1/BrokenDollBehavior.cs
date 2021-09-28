using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenDollBehavior : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void OnDestroy()
    {
        if ((GameObject.FindWithTag("brokenDoll") == null || GameObject.FindWithTag("brokenDollArm") == null) && GameObject.Find("Tresure Chest open grab") != null)
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
}
