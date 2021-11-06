using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    public List<GameObject> ObjectsToActivate;
    public List<GameObject> ObjectsToDeposit;
    public GameObject Deposit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {

        if (ObjectsToActivate != null)
        {
            foreach (GameObject obj in ObjectsToActivate)
            {
                obj.SetActive(true);
            }
        }

        if (ObjectsToDeposit != null)
        {
            foreach (GameObject obj in ObjectsToDeposit)
            {
                obj.transform.position = Deposit.transform.position;
            }
        }

    }

    private void OnTriggerExit(Collider collision)
    {
        Destroy(gameObject);

    }
}
