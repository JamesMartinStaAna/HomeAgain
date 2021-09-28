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


    // combine tutorial
    public GameObject combine;

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
        // when doll is picked up activate lockNkey collider
        if (GameObject.FindWithTag("brokenDoll") != null)
        {
            key_Collider = keyObject.GetComponent<Collider>();
            key_Collider.enabled = true;

        }

        // when lockNkey is picked up activate cardboardbox collider
        if (GameObject.FindWithTag("lockNkey") != null)
        {
            box_Collider = boxObject.GetComponent<Collider>();
            box_Collider.enabled = true;
        }


        // when lockNkey and cardboard box are stored activate rug and chest colliders and lockView
        if (GameObject.FindWithTag("lockNkey_receiver") == null && GameObject.FindWithTag("box_receiver") == null)
        {
            chest_Collider = chestObject.GetComponent<Collider>();
            rug_Collider = rugObject.GetComponent<Collider>();
            chest_Collider.enabled = true;
            rug_Collider.enabled = true;


        }

        // when regular rug is stored in deposit activate ingame blackmoon collider
        if (rugObject.transform.position == deposit.transform.position)
        {
            halfMoonObject.SetActive(true);
        }

        if (halfMoonObject.transform.position == deposit.transform.position)
        {
            desk_Collider = deskObject.GetComponent<Collider>();
            desk_Collider.enabled = true;
        }

        if (GameObject.FindGameObjectWithTag("blackMoon") != null && GameObject.FindGameObjectWithTag("whiteMoon") != null && GameObject.Find("desk open") != null)
        {
            combine.SetActive(true);
        }

        if (GameObject.FindGameObjectWithTag("fullMoon") != null && GameObject.Find("desk open") != null)
        {
            combine.SetActive(false);

        }



    }
}
