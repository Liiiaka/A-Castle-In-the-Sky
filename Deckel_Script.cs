using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deckel_Script : MonoBehaviour
{
    private Animator anim;
    //public bool boxUnlocked = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnMouseDown()
    { 
        // if (boxUnlocked == true)
        // {
        anim.SetTrigger("OpenDeckel");
        //  }
    }
}
