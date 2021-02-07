using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Openable_0bjects : Interactable
{
    public Sprite active;
    public Sprite inactive;

    private SpriteRenderer sr;
    private bool isActive;

    public override void Interact()
    {
        if (isActive)
            sr.sprite = inactive;
        else
            sr.sprite = active;

        isActive = !isActive;
    }

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = inactive;
    }
}
