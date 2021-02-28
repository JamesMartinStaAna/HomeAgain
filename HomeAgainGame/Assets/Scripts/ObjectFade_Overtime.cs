using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFade_Overtime : MonoBehaviour
{

    public GameObject End;
    public GameObject ObjectFade;
    Animator m_Animator;
    bool isfading = false;

    // Start is called before the first frame update

    void Start()
    {
        m_Animator = ObjectFade.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (isfading == true)
        {
            m_Animator.SetTrigger("fade");

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isfading = true;
         
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            End.SetActive(true);

        }
    }




}