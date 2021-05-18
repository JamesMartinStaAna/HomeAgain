using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_Interact_Object_Activator2 : MonoBehaviour
{


    //Activate after box dropped
    public GameObject boxView;

    //Activate after lock dropped
    public GameObject lockView;


    // deposit 
    public GameObject deposit;


    // Start is called before the first frame update
    void Start()
    {
        deposit = GameObject.Find("Deposit");
    }

    // Update is called once per frame
    void Update()
    {

        // when cardboard box is stored activate boxview
        if (GameObject.FindWithTag("lockNkey_receiver") != null)
        {
            boxView.SetActive(true);
        }

        // when lockNkey and cardboard box are stored activate rug and chest colliders and lockView
        if (GameObject.FindWithTag("lockNkey_receiver") == null && GameObject.FindWithTag("box_receiver") == null)
        {

            lockView.SetActive(true);

        }







    }
}
