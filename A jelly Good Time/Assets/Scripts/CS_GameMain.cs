using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_GameMain : MonoBehaviour
    {
        public static CS_GameMain instance;
        public bool gameOver;

        void Start()
        {
            InitGame();
        }
        void InitGame()
        {
            instance = this;
            gameOver = false;
        }
    }
}
