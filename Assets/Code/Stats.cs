using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// store and modify time point values
public class Stats : MonoBehaviour
{
    public float ogChooseLeft; // original month's time points
    public float ChooseLeft; // time points left over after math was made

    public void RunNumbers()
    {
        // resets to the month's based time point
        ChooseLeft = ogChooseLeft;
        // math for each of the four values, subtracting the time points
        foreach (GameObject buttonList in GameObject.FindGameObjectsWithTag("Button"))
        {
            if (buttonList.gameObject.GetComponent<Chosen>().chosen == true)
            {
                ChooseLeft -= buttonList.gameObject.GetComponent<Chosen>().value;
            }
        }
    }

    // updates the text with the time points value, by fps I believe
    void Update()
    {
        transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Time Points Left: " + ChooseLeft;
    }
}