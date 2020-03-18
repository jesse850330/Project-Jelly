using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class CS_PauseMenu : MonoBehaviour
{
    public GameObject canvasPrefab;
    private bool Pause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!Pause)
            {
                ClickEvent();
                Pause = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Pause = false;
        }
    }

    void ClickEvent()
    {
        Instantiate(canvasPrefab, Vector2.zero, Quaternion.identity);
    }

}
