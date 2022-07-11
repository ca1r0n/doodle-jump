using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
/*    private Rigidbody2D rb_Platforms;*/

    private Transform tr;

/*    [SerializeField] private GameObject platforms;*/
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
/*        rb_Platforms = platforms.GetComponent<Rigidbody2D>();*/
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        CharacterMove();
/*        if (onGround)
        {
            rb_Platforms.velocity = new Vector2(rb_Platforms.velocity.x, -jumpForce);
        }*/
        CheckingGround();
        if (transform.position.x < -23.75f)
        {
            transform.position = new Vector3(23.7f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 23.75f)
        {
            transform.position = new Vector3(-23.7f, transform.position.y, transform.position.z);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
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
        if ((Input.GetAxis("Horizontal") > 0))
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        else if ((Input.GetAxis("Horizontal") < 0))
        {
            transform.localScale = new Vector3(1,1,1);
        }

    }
}