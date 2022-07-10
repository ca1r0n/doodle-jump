using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.x < -23.75f)
        {
            transform.position = new Vector3(23.7f,transform.position.y, transform.position.z);
        }
        if (transform.position.x > 23.75f)
        {
            transform.position = new Vector3(-23.7f, transform.position.y, transform.position.z);
        }
    }
}
