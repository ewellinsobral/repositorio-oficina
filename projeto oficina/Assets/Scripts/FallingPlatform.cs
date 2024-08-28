using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallingTime;
   
    private TargetJoint2D target;
    private BoxCollider2D boxColl;
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           Invoke("Falling", fallingTime);
        }

    if(collision.gameObject.layer == 8)
        {
         Destroy(gameObject);
        }

    }
    void Falling()
    {
        target.enabled = false;
        boxColl.isTrigger = true;
    }
}
