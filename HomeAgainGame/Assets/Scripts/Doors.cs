using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : Interactable
{
    public GameObject target;
    

    public override void Interact()
    {
        Scene_Control.TransitionPlayer(target.transform.position);
        SoundManager.PlaySound("doorOpen");
    }

}