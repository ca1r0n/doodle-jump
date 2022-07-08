using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Rigidbody2D rb_Platforms;
    [SerializeField] private GameObject platforms;
    [SerializeField] private Transform Hero;
    [SerializeField] private float jumpForce = 15;
    private bool onGround = false;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask ground;
    [SerializeField] private LayerMask Rect;
    [SerializeField] private float moveSpead = 40;
    private float Rad = 0.4f;
    public bool CheckTrigger;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb_Platforms = platforms.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        CharacterMove();
        if (onGround)
        {
            rb_Platforms.velocity = new Vector2(rb_Platforms.velocity.x, -jumpForce);
        }
        CheckingGround();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
    }
    void CheckingGround()
    {
        if (CheckTrigger)
            onGround = false;
        else
            onGround = Physics2D.OverlapCircle(GroundCheck.position, Rad, ground);
    }
    private void CharacterMove()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpead, rb.velocity.y);
    }
}