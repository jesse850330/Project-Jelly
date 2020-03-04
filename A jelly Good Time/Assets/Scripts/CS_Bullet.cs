using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Bullet : MonoBehaviour
{
    public float speed;
    public AudioClip Jelly;
    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        Destroy(gameObject, 1.25f);
    }

    void OnCollisionEnter(Collision pew)
    {
        if (pew.gameObject.tag == "Enemy")
        {
            Destroy(pew.gameObject.transform.parent.gameObject);
            AudioSource.PlayClipAtPoint(Jelly,transform.localPosition);
        }
        
    }
}
