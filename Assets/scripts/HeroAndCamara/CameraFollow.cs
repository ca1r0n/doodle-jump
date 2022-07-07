using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject gameobj;
    public float CameraSpead = 2;
    void Start()
    {
        
    }

    void Update()
    {
        float pos = gameobj.transform.position.y - transform.position.y;
        transform.position = new Vector3( gameobj.transform.position.x, transform.position.y +(pos * Time.deltaTime *CameraSpead), transform.position.z);
    }
}
