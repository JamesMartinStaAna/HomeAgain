using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_Destroy_On_End : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;



    private void OnEnable()
    {
        textDisplay.text = string.Empty;
        StartCoroutine(Type());
        index = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GameObject.FindWithTag("open_image") != null)
        {
            if (textDisplay.text == sentences[index])
            {
                NextSentence();
            }
            else
            {
                StopAllCoroutines();
                textDisplay.text = sentences[index];
            }
        }
    }


    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            SoundManager.PlaySound("type");
            yield return new WaitForSeconds(typingSpeed);
        }

    }

    public void NextSentence()
    {


        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = string.Empty;
            StartCoroutine(Type());
        }

        else
        {
            Destroy(gameObject);

        }



    }


    private void OnDisable()
    {
        textDisplay.text = string.Empty;

    }

}


