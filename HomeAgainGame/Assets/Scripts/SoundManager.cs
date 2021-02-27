using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip popUpSound, pickUpSound, drawerOpenSound, cabinentOpenSound, ShowerSound, doorOpenSound, lightSwitchSound, typeSound, mugSound, trashSound, spoonSound, clickSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        popUpSound = Resources.Load<AudioClip>("popUp");
        pickUpSound = Resources.Load<AudioClip>("pickUp");
        drawerOpenSound = Resources.Load<AudioClip>("drawerOpen");
        cabinentOpenSound = Resources.Load<AudioClip>("cabinentOpen");
        ShowerSound = Resources.Load<AudioClip>("Shower");
        doorOpenSound = Resources.Load<AudioClip>("doorOpen");
        lightSwitchSound = Resources.Load<AudioClip>("lightSwitch");
        typeSound = Resources.Load<AudioClip>("type");
        mugSound = Resources.Load<AudioClip>("mug");
        trashSound = Resources.Load<AudioClip>("trash");
        spoonSound = Resources.Load<AudioClip>("spoon");
        clickSound = Resources.Load<AudioClip>("click");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {

            case "popUp":
                audioSrc.PlayOneShot(popUpSound);
                break;

            case "doorOpen":
                audioSrc.PlayOneShot(doorOpenSound);
                break;

            case "lightSwitch":
                audioSrc.PlayOneShot(lightSwitchSound);
                break;

            case "type":
                audioSrc.PlayOneShot(typeSound);
                break;

            case "mug":
                audioSrc.PlayOneShot(mugSound);
                break;

            case "trash":
                audioSrc.PlayOneShot(trashSound);
                break;

            case "spoon":
                audioSrc.PlayOneShot(spoonSound);
                break;

            case "click":
                audioSrc.PlayOneShot(clickSound);
                break;
        }
    }
}
