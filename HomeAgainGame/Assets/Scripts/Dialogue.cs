using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialogue : Interactable
{
    public GameObject dialogueView;
    private bool isActive;
    public Animator animator;

   

    public override void Interact()
    {
        dialogueView.SetActive(true);
    }
}
