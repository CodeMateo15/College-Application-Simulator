using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stats : MonoBehaviour
{
    public float ogChooseLeft;
    public float ChooseLeft;

    public void RunNumbers()
    {
        ChooseLeft = ogChooseLeft;
        foreach (GameObject buttonList in GameObject.FindGameObjectsWithTag("Button"))
        {
            if (buttonList.gameObject.GetComponent<Chosen>().chosen == true)
            {
                ChooseLeft -= buttonList.gameObject.GetComponent<Chosen>().value;
            }
        }
    }

    void Update()
    {
        transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Time Points Left: " + ChooseLeft;
    }
}