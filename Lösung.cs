using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public  class Lösung : MonoBehaviour
{
    public static bool solution;
    public TMP_InputField InputUI;
    public GameObject InputField;

    public void CheckSol()
    {
        if (InputUI.text=="wind"|InputUI.text=="Wind"|InputUI.text=="WIND")
        {
            solution = true;
            InputField.SetActive(false);
        }
    }

    public void Close()
    {
        InputField.SetActive(false);
    }


}
