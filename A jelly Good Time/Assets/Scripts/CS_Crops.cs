using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Crops : CS_HPControl
    {

        void Start()
        {
            Init();
        }
        public override void Death()
        {
            base.Death();
            CS_GameMain.instance.gameOver = true;
        }
    }
}