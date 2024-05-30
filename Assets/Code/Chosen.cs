using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// each button has a chosen file on it to determine's what happens if chosen (color, value, action, etc)
public class Chosen : MonoBehaviour
{
    public Button yourButton; // assign the button from the parent
    public bool chosen; // boolean to determine action if clicked 
    public bool unInteractable; // determine if the button can be clicked or not
    public float value; // value of the time point that was picked
    public Image image; // image of button to change color

    // assign values at start of game
    void Start()
    {
        image = this.gameObject.GetComponent<Image>();
        Button btn = this.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (chosen == true)
        {
            chosen = false;
            image.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
            transform.parent.gameObject.GetComponent<Choose>().ChildNumber = value;
            transform.parent.gameObject.GetComponent<Choose>().TextNumber = 0;
            GameObject.Find("Stats").GetComponent<Stats>().RunNumbers();
            foreach (GameObject buttonParentList in GameObject.FindGameObjectsWithTag("ParentButton"))
            {
                buttonParentList.gameObject.GetComponent<Choose>().AddExtra();
            }
            GameObject.Find("Stats").GetComponent<Stats>().RunNumbers();
        }
        else
        {
            chosen = true;
            transform.parent.gameObject.GetComponent<Choose>().TextNumber = value;
            image.GetComponent<Image>().color = new Color(0.2725081f, 1f, 0.08018869f, 1);
            GameObject.Find("Stats").GetComponent<Stats>().RunNumbers();
            foreach (GameObject buttonParentList in GameObject.FindGameObjectsWithTag("ParentButton"))
            {
                buttonParentList.gameObject.GetComponent<Choose>().RemoveExtra();
            }
            GameObject.Find("Stats").GetComponent<Stats>().RunNumbers();
        }
    }
}