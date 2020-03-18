using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;

public class CS_GameManager : MonoBehaviour
{
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void OnStartGame(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    public void OnCloseGame()
    {
        Application.Quit();
    }

}
