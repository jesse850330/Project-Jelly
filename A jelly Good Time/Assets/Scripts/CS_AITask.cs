using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_AITask : MonoBehaviour
    {
        private static CS_AITask _Instance = null;
        public static CS_AITask Instance
        {
            get
            {
                if (_Instance == null)
                {
                    GameObject obj = new GameObject("AISpawn");
                    _Instance = obj.AddComponent<CS_AITask>();
                }
                return _Instance;
            }

        }
        public class TimeTask
        {

            public Action callback;
            public float delayTime;
            public float destTime;
            public int count;
        }
        List<TimeTask> timeTaskList = new List<TimeTask>();
        public void AddTimeTask(Action _callback, float _delayTime, int _count = 1)
        {
            timeTaskList.Add(new TimeTask()
            {
                callback = _callback,
                delayTime = _delayTime,
                destTime = Time.realtimeSinceStartup + _delayTime,
                count = _count

            });
        }
        private void update()
        {
            for (int i = 0; i < timeTaskList.Count; i++)
            {
                TimeTask task = timeTaskList[i];
                if (Time.realtimeSinceStartup >= task.destTime)
                {
                    task.callback?.Invoke();
                    if (task.count == 1)
                        timeTaskList.RemoveAt(i);
                    else if (task.count > 1)
                        task.count--;
                    task.destTime += task.delayTime;

                }
            }
        }
    }
}