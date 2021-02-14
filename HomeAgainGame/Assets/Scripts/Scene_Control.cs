using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_Control : MonoBehaviour
{
    public Image fade;
    private static Scene_Control instance;
    private GameObject player;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject); 
    
    }

    public static void TransitionPlayer(Vector3 pos)
    {
        instance.StartCoroutine(instance.Transition(pos));
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private IEnumerator Transition(Vector3 pos)
    {
        fade.gameObject.SetActive(true);

        for(float f = 0; f < 1; f += Time.deltaTime / 0.25f)
        {
            fade.color = new Color(0, 0, 0, Mathf.Lerp(0f, 1f, f));
            yield return null;
        }

        player.transform.position = new Vector3 (pos.x, 0, 0);

        yield return new WaitForSeconds(1);

        for (float f = 0; f < 1; f += Time.deltaTime / 0.25f)
        {
            fade.color = new Color(0, 0, 0, Mathf.Lerp(1f, 0f, f));
            yield return null;
        }

        fade.gameObject.SetActive(false);
    }
}
