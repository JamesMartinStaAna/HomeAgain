using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_combine_notif : MonoBehaviour
{


    //Activate after box dropped
    public GameObject moonView;


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
        if (GameObject.FindWithTag("fullMoon") != null)
        {
            moonView.SetActive(true);
        }

 
        







    }
}
