using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2Falltuer : MonoBehaviour
{
    private Animator anim;
    public GameObject ButtonL2UI;
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
            ButtonL2UI.SetActive(true);
        }
    }
}
