using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Kiste : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Lösung.solution == true)
        {
            anim.SetTrigger("Open");
            Lösung.solution = false;
        }
    }
}
