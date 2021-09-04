using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Object_Activator : MonoBehaviour
{
    Collider Maymug_Collider;
    Collider Dadmug_Collider;
    Collider Mommug_Collider;
    Collider Mugholder_Collider;
    Collider key_Collider;
    Collider Spoon_Collider;
    Collider FootStool_Collider;
    Collider KitchenCabinet_Collider;



    public GameObject MayMugObject;
    public GameObject DadMugObject;
    public GameObject MomMugObject;
    public GameObject mugholderObject;
    public GameObject keyObject;
    public GameObject spoonObject;
    public GameObject FootstoolObject;
    public GameObject KitchenCabinetObject;



    // Start is called before the first frame update
    void Start()
    {
        Maymug_Collider = MayMugObject.GetComponent<Collider>();
        Dadmug_Collider = DadMugObject.GetComponent<Collider>();
        Mommug_Collider = MomMugObject.GetComponent<Collider>();
        Mugholder_Collider = mugholderObject.GetComponent<Collider>();

        key_Collider = keyObject.GetComponent<Collider>();
        Spoon_Collider = spoonObject.GetComponent<Collider>();

        FootStool_Collider = FootstoolObject.GetComponent<Collider>();
        KitchenCabinet_Collider = KitchenCabinetObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Maymug_drop") == null && GameObject.Find("Dadmug_drop") == null && GameObject.Find("Mommug_drop") == null)
        {
            key_Collider.enabled = true;
            Spoon_Collider.enabled = true;
            Mugholder_Collider.enabled = false;
        }

        if (GameObject.Find("spoon_smol") != null)
        {
            FootStool_Collider.enabled = true;
            KitchenCabinet_Collider.enabled = true;

        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
       

            Maymug_Collider.enabled = true;
            Dadmug_Collider.enabled = true;
            Mommug_Collider.enabled = true;
            Mugholder_Collider.enabled = true;

        }

   
    }

}
