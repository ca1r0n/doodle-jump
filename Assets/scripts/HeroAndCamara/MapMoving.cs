/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMoving : MonoBehaviour
{

    public Transform GroundCheck;
    private float Rad = 0.4f;
    public LayerMask ground;
    public bool onGround = false;

    void Update()
    {
        CheckingGround();
        if (onGround)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (25 * Time.deltaTime), transform.position.z);
        }
    }
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, Rad, ground);

    }
}
*/