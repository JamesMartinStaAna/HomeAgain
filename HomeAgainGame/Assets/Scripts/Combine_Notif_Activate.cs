using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine_Notif_Activate : MonoBehaviour
{


    
    public GameObject ActivateNotif;
    public GameObject Deposit;
    public string ObjectToBeChecked;
    public List<GameObject> WorldObjectsToActivate;
    public List<GameObject> WorldObjectsToDeposit;

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

                // Activate world objects
                foreach (GameObject obj in WorldObjectsToActivate)
                {
                    obj.SetActive(true);
                }

                // Move unneeded objects to deposit
                foreach (GameObject obj in WorldObjectsToDeposit)
                {
                    obj.transform.position = Deposit.transform.position;
                }
            }
        }
   

 
     

    }
}
