using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.y < 0)
        {
            Debug.Log("Jump!");
            Doodle.instance.DoodleRigid.velocity = Vector2.up * forceJump; 
        }
    }
}
