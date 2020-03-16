using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectJelly.FPP
{
    public class CS_Score : MonoBehaviour
    {
        public static Text Score;
        public static Text Mag;
        public static Text Ammo;
        public static Text AbilityM;
        public static float x = 0;
        public static float y = 0;
        public static float z = 0;
        public static float c = 0;
        void Start()
        {
            Score = GameObject.Find("Score").GetComponent<Text>();
            Mag = GameObject.Find("Mag").GetComponent<Text>();
            Ammo = GameObject.Find("Ammo").GetComponent<Text>();
            AbilityM = GameObject.Find("AbilityM").GetComponent<Text>();
        }
    }
}


