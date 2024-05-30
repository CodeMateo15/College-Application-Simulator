using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// the buttons for each of the four categories, it is a bit hard coded so it might be prone to bugs. Needs more testing
public class Choose : MonoBehaviour
{

    public float ParentNumber;
    public float ChildNumber;
    public float TextNumber;
    public float valueParent;

    public void RemoveExtra()
    {
        ParentNumber = GameObject.Find("Stats").GetComponent<Stats>().ChooseLeft;
        ChildrenAssign();
        if (ParentNumber <= 3f)
        {
            if (transform.GetChild(4).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(4).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(4).gameObject.SetActive(false);
            }
        }
        if (ParentNumber <= 2f)
        {
            if (transform.GetChild(3).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(3).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(3).gameObject.SetActive(false);
            }
        }
        if (ParentNumber <= 1f)
        {
            if (transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(2).gameObject.SetActive(false);
            }
        }
        if (ParentNumber <= 0f)
        {
            if (transform.GetChild(1).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }

    public void ChildrenAssign()
    {
        if (transform.GetChild(4).gameObject.GetComponent<Chosen>().chosen == true)
        {
            transform.GetChild(3).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(3).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(3).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(3).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
            transform.GetChild(2).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(2).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(1).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
        }
        if (transform.GetChild(3).gameObject.GetComponent<Chosen>().chosen == true)
        {
            transform.GetChild(2).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(2).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(1).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
        }
        if (transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen == true)
        {
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = false;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().chosen = false;
            transform.GetChild(1).gameObject.GetComponent<Image>().color = new Color(0.4431373f, 0.4431373f, 0.4431373f, 1);
        }
    }

    public void AddExtra()
    {
        ParentNumber = GameObject.Find("Stats").GetComponent<Stats>().ChooseLeft;
        ChildrenUnassign();
        if (ParentNumber >= 1f)
        {
            if (transform.GetChild(1).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        if (ParentNumber >= 2f)
        {
            if (transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(2).gameObject.SetActive(true);
            }
        }
        if (ParentNumber >= 3f)
        {
            if (transform.GetChild(3).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(3).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(3).gameObject.SetActive(true);
            }
        }
        if (ParentNumber >= 4f)
        {
            if (transform.GetChild(4).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(4).gameObject.GetComponent<Chosen>().unInteractable == false)
            {
                transform.GetChild(4).gameObject.SetActive(true);
            }
        }
    }

    public void ChildrenUnassign()
    {
        if (ChildNumber == 4 && transform.GetChild(4).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(4).gameObject.GetComponent<Chosen>().unInteractable == false)
        {
            transform.GetChild(3).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(3).gameObject.GetComponent<Chosen>().unInteractable = false;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable = false;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = false;
        }
        if (ChildNumber == 3 && transform.GetChild(3).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(3).gameObject.GetComponent<Chosen>().unInteractable == false)
        {
            transform.GetChild(2).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable = false;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = false;
        }
        if (ChildNumber == 2 && transform.GetChild(2).gameObject.GetComponent<Chosen>().chosen == false && transform.GetChild(2).gameObject.GetComponent<Chosen>().unInteractable == false)
        {
            transform.GetChild(1).gameObject.GetComponent<Chosen>().yourButton.interactable = true;
            transform.GetChild(1).gameObject.GetComponent<Chosen>().unInteractable = false;
        }
    }

    void Update()
    {
        transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = TextNumber.ToString();
    }
}