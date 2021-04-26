using UnityEngine;


public class View : Interactable
{

    public GameObject objView;
    private bool isActive;
    private Animator animator;

    public override void Interact()
    {

        isActive = !isActive;


        if (isActive)
        {
            SoundManager.PlaySound("popUp");
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