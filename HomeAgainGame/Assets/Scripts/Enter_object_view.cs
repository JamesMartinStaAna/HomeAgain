using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_object_view : MonoBehaviour
{
    public GameObject viewNotif;
    public GameObject gameActive;
    public GameObject deposit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            viewNotif.SetActive(true);
            transform.position = deposit.transform.position;
            gameActive.SetActive(true);
        }
    }
}
