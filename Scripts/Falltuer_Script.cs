using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falltuer_Script : MonoBehaviour
{
    private Animator anim;
    public GameObject ButtonUI;
 
     void Start()
     {
         anim = GetComponent<Animator>();
     }
 
  
 
     private void OnTriggerEnter(Collider other)
     {
         if (other.tag == "Key")
         {
             //Debug.Log("Door unlocked");
             Destroy(other.gameObject);
             anim.SetTrigger("Open");
             ButtonUI.SetActive(true);
         }
     }
 }