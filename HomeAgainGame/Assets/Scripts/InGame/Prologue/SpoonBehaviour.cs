using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonBehaviour : MonoBehaviour
{
    public GameObject FootstoolObject;
    public GameObject KitchenCabinetObject;


    public void OnSpoonDone()
    {
        FootstoolObject.GetComponent<Collider>().enabled = true;
        KitchenCabinetObject.GetComponent<Collider>().enabled = true;
    }
}
