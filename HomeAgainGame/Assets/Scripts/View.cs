using UnityEngine;

public class View : Interactable
{

    public GameObject view;

    private bool isActive;

    public override void Interact()
    {

        if (isActive)
        {
            view.SetActive(true);
            isActive = true;
        }
        else
        {
            view.SetActive(false);
            isActive = false;
        }

    }
}