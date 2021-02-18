using UnityEngine;


public class View : Interactable
{

    public GameObject objView;
    private bool isActive;
    public Animator animator;

    public override void Interact()
    {


        isActive = !isActive;


        if (isActive)
        {
            objView.SetActive(true);
            isActive = true;
            
        }
        else
        {
            objView.SetActive(false);
            isActive = false;
        }

    }
}