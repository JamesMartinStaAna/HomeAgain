using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_combine_notif_3 : MonoBehaviour
{


    //Activate after box dropped
    public GameObject letterView;


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
        if (GameObject.FindWithTag("letter") != null)
        {
            letterView.SetActive(true);
        }

 
        







    }
}
