using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Activate : Interactable
{

    private Inventory inventory;
    public GameObject Deposit;
    public List<GameObject> ObjectsToActivate;
    public List<GameObject> ObjectsToDeposit;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    public override void Interact()
    {
        SoundManager.PlaySound("popUp");

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
    }
}
