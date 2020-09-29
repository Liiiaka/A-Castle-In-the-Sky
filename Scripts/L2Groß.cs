using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Groß : MonoBehaviour
{
    private Animator anim;
    //public bool boxUnlocked = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TruheKey")
        {
            //Debug.Log("Door unlocked");
            Destroy(other.gameObject);
            anim.SetTrigger("Open");
        }
    }
}