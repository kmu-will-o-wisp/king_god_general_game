using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScriptManager : MonoBehaviour
{
    public GameObject talkPannel;
    //public Text textName;
    public TextMeshProUGUI NPCname;
    public TextMeshProUGUI sentence;
    public bool isTalking;
    int clickCount = 0;

void Awake()
    {
        if (clickCount == 0)
        {
            talkPannel.SetActive(false);
            //text.text = "1st script";
            clickCount++;
        }
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (clickCount == 1)
            {
                talkPannel.SetActive(true);
                NPCname.text = "Gaon";
                sentence.text = "Hi guys!";
                isTalking = true;
                clickCount++;
            }
            else if (clickCount == 2)
            {
                NPCname.text = "NPC";
                sentence.text = "Hi myname is NPC!";
                clickCount++;
            }
            else if (clickCount == 3)
            {
                NPCname.text = "Gaon";
                sentence.text = "My name is Gaon!";
                clickCount++;
            }
            else
            {
                talkPannel.SetActive(false);

            }
            //talkPannel.SetActive(false);

            Debug.Log(clickCount);
        }
    }

}