using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_combine_notif_2 : MonoBehaviour
{


    //Activate after box dropped
    public GameObject dollView;


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
        if (GameObject.FindWithTag("fixedDoll") != null)
        {
            dollView.SetActive(true);
        }

 
        







    }
}
