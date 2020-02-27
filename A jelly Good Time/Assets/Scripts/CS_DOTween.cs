using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
 
public class CS_DOTween : MonoBehaviour
{
    public int index = 1;
 
    void Start()
    {
        
    }
 
    void Update()
    {

        if (index == 1)
        {
            transform.DOMove(transform.position + new Vector3(0, 0.1f, 0), 0.1f);
            Invoke("MoveTuBiao2", 1);
        }
        else {
            transform.DOMove(transform.position - new Vector3(0, 0.1f, 0), 0.1f);
            Invoke("MoveTuBiao1", 1);
        }
        
    }
 
    private void MoveTuBiao1() {
        index = 1;
    }
 
 
    private void MoveTuBiao2()
    {
        index = 2;
    }
}