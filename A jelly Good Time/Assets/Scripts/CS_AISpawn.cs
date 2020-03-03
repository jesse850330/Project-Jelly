using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace ProjectJelly.FPP
{
    public class CS_AISpawn : MonoBehaviour
    {
        Dictionary<string, CS_AIAttack> enemyDict = new Dictionary<string, CS_AIAttack>();

        public void Init()
        {
            CS_AIAttack[] enemys = Resources.LoadAll<CS_AIAttack>("Assets/Prefab");
            for (int i = 0; i < enemys.Length; i++)
            {
                if (!enemyDict.ContainsKey(enemys[i].name))
                    enemyDict.Add(enemys[i].name, enemys[i]);
            }
        }
        public void CreateEnemy(string name, float delay, int count = 1)
        {
            if (CS_GameMain.instance.gameOver == false)
                CS_AITask.Instance.AddTimeTask(() => Instantiate(
                    enemyDict[name], transform.position, transform.rotation).Init(),
                delay, count);
        }

        void Awake()
        {
            CreateEnemy("AI02", 1, 5);
            CS_AITask.Instance.AddTimeTask(() => CreateEnemy("AI01", 0.5f, 10), 5);
        }
    }
}