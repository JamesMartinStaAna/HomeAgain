using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_Interact_Object_Activator1 : MonoBehaviour
{
    // activate collider
    Collider key_Collider;
    Collider box_Collider;
    Collider chest_Collider;
    Collider rug_Collider;
    Collider desk_Collider;

    public GameObject keyObject;
    public GameObject boxObject;
    public GameObject chestObject;
    public GameObject rugObject;
    public GameObject deskObject;




    // deposit 
    public GameObject deposit;

    // spawn object
    public GameObject halfMoonObject;

    // Start is called before the first frame update
    void Start()
    {
        deposit = GameObject.Find("Deposit");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("brokenDoll") != null)
        {
            key_Collider = keyObject.GetComponent<Collider>();
            key_Collider.enabled = true;

        }

        if (GameObject.FindWithTag("lockNkey") != null)
        {
            box_Collider = boxObject.GetComponent<Collider>();
            box_Collider.enabled = true;
        }

        if (GameObject.FindWithTag("lockNkey_receiver") == null && GameObject.FindWithTag("box_receiver") == null)
        {
            chest_Collider = chestObject.GetComponent<Collider>();
            chest_Collider.enabled = true;
            rug_Collider = rugObject.GetComponent<Collider>();
            rug_Collider.enabled = true;
        }

        if (rugObject.transform.position == deposit.transform.position)
        {
            halfMoonObject.SetActive(true);
        }

        if (halfMoonObject.transform.position == deposit.transform.position)
        {
            desk_Collider = deskObject.GetComponent<Collider>();
            desk_Collider.enabled = true;
        }
    }
}
