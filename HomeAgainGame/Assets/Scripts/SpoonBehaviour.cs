using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoonBehaviour : MonoBehaviour
{
    public GameObject FootstoolObject;
    public GameObject KitchenCabinetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSpoonDone()
    {
        FootstoolObject.GetComponent<Collider>().enabled = true;
        KitchenCabinetObject.GetComponent<Collider>().enabled = true;
    }
}
