using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Next_Month : MonoBehaviour
{
    public float monthCount;
    public string monthType;
    public float totalMonth;
    public float yearCount;
    private bool changeYear;
    public float yearString;
    public string standing;

    void Update()
    {
        if (monthCount == 5 && changeYear == false)
        {
            yearCount += 1f;
            changeYear = true;
        }
        if (monthCount == 6)
        {
            changeYear = false;
        }
    }

    public void NextMonthClick()
    {
        monthCount += 1f;
        totalMonth += 1f;
        if (monthCount >= 13)
        {
            monthCount = 1f;
        }
        ChangeTimeString();
        transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = monthType + " " + yearString + "\n" + "(" + totalMonth + " months in total)";
        transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Standing:\n" + standing;
    }

    void ChangeTimeString()
    {
        if (monthCount == 1)
        {
            monthType = "January";
        }
        if (monthCount == 2)
        {
            monthType = "February";
        }
        if (monthCount == 3)
        {
            monthType = "March";
        }
        if (monthCount == 4)
        {
            monthType = "April";
        }
        if (monthCount == 5)
        {
            monthType = "May";
        }
        if (monthCount == 6)
        {
            monthType = "June";
        }
        if (monthCount == 7)
        {
            monthType = "July";
        }
        if (monthCount == 8)
        {
            monthType = "August";
        }
        if (monthCount == 9)
        {
            monthType = "September";
        }
        if (monthCount == 10)
        {
            monthType = "October";
        }
        if (monthCount == 11)
        {
            monthType = "November";
        }
        if (monthCount == 12)
        {
            monthType = "December";
        }
        if (totalMonth <= 5)
        {
            yearString = 2023;
        }
        if (totalMonth >= 6 && totalMonth <= 17)
        {
            yearString = 2024;
        }
        if (totalMonth >= 18 && totalMonth <= 29)
        {
            yearString = 2025;
        }
        if (totalMonth >= 30 && totalMonth <= 41)
        {
            yearString = 2026;
        }
        if (totalMonth >= 42 && totalMonth <= 53)
        {
            yearString = 2027;
        }
        if (yearCount == 1)
        {
            standing = "Freshman";
        }
        if (yearCount == 2)
        {
            standing = "Sophmore";
        }
        if (yearCount == 3)
        {
            standing = "Junior";
        }
        if (yearCount == 4)
        {
            standing = "Senior";
        }
    }
}
