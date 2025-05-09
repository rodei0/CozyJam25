using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    [HideInInspector]
    public float horizontal;
    [HideInInspector]
    public float vertical;
    private Rigidbody2D rb;
    private Vector2 movement;
    private bool isFacingRight = true;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Flip();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        movement = new Vector2(horizontal, vertical).normalized * speed;
        rb.linearVelocity = movement;
    }

    private void Flip()
    {
        if ((isFacingRight && horizontal < 0f) || (!isFacingRight && horizontal > 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;

        }
    }
}
