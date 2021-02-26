using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object_Activator : MonoBehaviour
{
    Collider maymug_Collider;
    Collider dadmug_Collider;
    Collider mommug_Collider;
    Collider mugholder_Collider;
    Collider spoon_Collider;
    Collider plate_Collider;
    Collider key_Collider;
    Collider footstool_Collider;
    public GameObject MayMugObject;
    public GameObject DadMugObject;
    public GameObject MomMugObject;
    public GameObject mugholderObject;
    public GameObject spoonObject;
    public GameObject plateObject;
    public GameObject keyObject;
    public GameObject footstoolObject;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            maymug_Collider = MayMugObject.GetComponent<Collider>();
            dadmug_Collider = DadMugObject.GetComponent<Collider>();
            mommug_Collider = MomMugObject.GetComponent<Collider>();
            mugholder_Collider = mugholderObject.GetComponent<Collider>();
            spoon_Collider = spoonObject.GetComponent<Collider>();
            plate_Collider = plateObject.GetComponent<Collider>();
            key_Collider = keyObject.GetComponent<Collider>();
            footstool_Collider = footstoolObject.GetComponent<Collider>();


            maymug_Collider.enabled = true;
            dadmug_Collider.enabled = true;
            mommug_Collider.enabled = true;
            mugholder_Collider.enabled = true;
            spoon_Collider.enabled = true;
            plate_Collider.enabled = true;
            key_Collider.enabled = true;
            footstool_Collider.enabled = true;
        }
    }

}
