using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog_no_button : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    private void OnEnable()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {

    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            SoundManager.PlaySound("lightSwitch");
            yield return new WaitForSeconds(typingSpeed);
        }

    }

    public void NextSentence()
    {


        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }

        else if (index == sentences.Length - 1)
        {
            index = 0;

        }

    }


    private void OnDisable()
    {
        textDisplay.text = "";

    }

}
