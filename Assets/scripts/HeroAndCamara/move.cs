using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D rb_Platforms;
    public GameObject platforms;
    public Transform Point;
    public Transform Hero;
    public float jumpForce = 15;
    public bool onGround = false;
    public Transform GroundCheck;
    public LayerMask ground;
    public LayerMask Rect;
    public float moveSpead = 40;
    private float Rad = 0.4f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb_Platforms = platforms.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CheckingGround();
        if (onGround)
        {
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb_Platforms.velocity = new Vector2(rb_Platforms.velocity.x, -jumpForce);
        }
        CharacterMove();
    }
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, Rad, ground);
    }
    private void CharacterMove()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpead, rb.velocity.y);
    }
}