using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muggone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Dad_Mug_pickup").transform.position == GameObject.Find("Deposit").transform.position)
        {
            Destroy(gameObject);
            Debug.Log("Mug BG Destroyed");
        }

    }
}
