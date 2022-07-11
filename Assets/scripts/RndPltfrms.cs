using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RndPltfrms : MonoBehaviour
{
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask ground;
    private float Rad = 0.4f;
    private Rigidbody2D rb_Platforms;
    public GameObject Platforms;
    [SerializeField] private float jumpForce = 20;
    private bool onGround = false;
    public bool CheckTrigger;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new Vector3(1, 1, 1);
        Instantiate(Platforms, pos, Quaternion.identity);
        rb_Platforms = Platforms.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            rb_Platforms.velocity = new Vector2(rb_Platforms.velocity.x, -jumpForce);
        }
        CheckingGround();
    }
    void CheckingGround()
    {
        if (CheckTrigger)
            onGround = false;
        else
            onGround = Physics2D.OverlapCircle(rb_Platforms.position, Rad, ground);
    }
}
