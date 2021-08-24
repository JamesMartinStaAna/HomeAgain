using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ItemPuzzle
{
    public string Name;
    public GameObject HighlightRemove;
    public GameObject WorldObjectToRemove;
    public GameObject WorldObjectToSwap;
    public GameObject Deposit;
}

public class Drop_and_Activate : MonoBehaviour
{
    public List<ItemPuzzle> Items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
