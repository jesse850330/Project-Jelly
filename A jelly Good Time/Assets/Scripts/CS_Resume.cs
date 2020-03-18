using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class CS_Resume : MonoBehaviour
{
    public GameObject canvas;
    void Start()
    {
        List<string> btnsName = new List<string>();
        btnsName.Add("ResumeButton");
        btnsName.Add("MenuButton");
        btnsName.Add("QuitButton");

        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate ()
            {
                this.OnClick(btnObj);
            });
        }
    }

    public void OnClick(GameObject sender)
    {
        switch (sender.name)
        {
            case "ResumeButton":
                ClickEvent();
                Debug.Log("ResumeButton");
                break;
            case "MenuButton":
                Debug.Log("MenuButton");
                break;
            case "QuitButton":
                Debug.Log("QuitButton");
                break;
            default:
                Debug.Log("none");
                break;
        }
    }


    void ClickEvent()
    {
        Destroy(canvas);
    }
    void OnEnable()
    {
        Time.timeScale = 0f;
    }

    void OnDisable()
    {
        Time.timeScale = 1f;
    }

}
