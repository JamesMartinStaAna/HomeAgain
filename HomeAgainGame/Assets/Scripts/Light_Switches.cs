using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Light_Switches : Interactable
{
    public Sprite active;
    public Sprite inactive;
    public GameObject Llight;

    private SpriteRenderer sr;
    private bool isActive;

    public override void Interact()
    {
        // sprite active or inactive
        if (isActive)
            sr.sprite = inactive;
        else
            sr.sprite = active;

        isActive = !isActive;


        if (isActive)
        {
            SoundManager.PlaySound("lightSwitch");
            Llight.SetActive(true);
            isActive = true;
        }
        else
        {
            SoundManager.PlaySound("lightSwitch");
            Llight.SetActive(false);
            isActive = false;
        }

    }


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = inactive;
   
    }
}
