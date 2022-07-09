using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doodle : MonoBehaviour
{
    float horizontal;
    public Rigidbody2D DoodleRigid;
    public static Doodle instance;
    public float forceStartJump;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        this.DoodleRigid.velocity = Vector2.up * forceStartJump; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
    }
}
