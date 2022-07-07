using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject platforms;
    public float jumpForce = 15;
    private Vector2 MoveVector;
    public bool onGround = false;
    public Transform GroundCheck;
    public LayerMask ground;
    public float moveSpead = 40;
    private float Rad = 0.4f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CheckingGround();
        if (onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        }
        CharacterMove();
    }
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, Rad, ground);

    }
    private void CharacterMove()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveVector.x * moveSpead, rb.velocity.y);
    }
}