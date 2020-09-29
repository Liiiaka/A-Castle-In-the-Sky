using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raetsel : MonoBehaviour
{
    public GameObject RaetselUI;
    
    public void Look()
    {
        RaetselUI.SetActive(true);
    }

    public void Close()
    {
        RaetselUI.SetActive(false);
    }
}
