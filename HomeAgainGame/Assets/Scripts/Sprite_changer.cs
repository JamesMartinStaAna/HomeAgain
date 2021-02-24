using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_changer : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject[] ObjectsChange;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {

        }
    }
}
