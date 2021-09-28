using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine_Notif_Activate : MonoBehaviour
{


    
    public GameObject ActivateNotif;
    public GameObject Deposit;
    public string ObjectToBeChecked;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        // when cardboard box is stored activate boxview
        if (ActivateNotif != null)
        {
            if (GameObject.FindWithTag(ObjectToBeChecked) != null)
            {
                ActivateNotif.SetActive(true);
            }
        }
   

 
        







    }
}
