using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


// to update the text with correct month and store data on it
public class Next_Month : MonoBehaviour
{
    public float monthCount; // month type, month 3 == March, tracks also when a year changes
    public string monthType; // string to showcase month type, month 3 == March
    public float totalMonth; // total month number (ex. 24 months)
    public float yearCount; // year tracker
    public float yearString; // string to showcase what year it is
    public string standing; // what year the student is in (ex. freshman vs. sophmore)

    // method when the button gets clicked to change data about months and standing
    public void NextMonthClick()
    {
        monthCount += 1f;
        totalMonth += 1f;
        if (monthCount >= 13)
        {
            monthCount = 1f;
        }
        if (monthCount == 5)
        {
            yearCount += 1f;
        }
        // activate string changes
        ChangeTimeString();
        // change the actual texts with the new strings
        transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = monthType + " " + yearString + "\n" + "(" + totalMonth + " months in total)";
        transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = "Standing:\n" + standing;
    }

    // deals with all the specific strings for Months and standing, could it be done better?
    void ChangeTimeString()
    {
        // months 1-12 strings
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
        // year strings
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
        // standing strings
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
        if (yearCount == 5)
        {
            standing = "Graduated";
        }
    }
}
