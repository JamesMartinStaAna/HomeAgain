using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : Interactable
{
    public GameObject target;
    

    public override void Interact()
    {
 
    }

    public override void InteractdoorUp()
    {
        Scene_Control.TransitionPlayer(target.transform.position);
    }
}