using UnityEngine;

public class PlayerControllert : MonoBehaviour
{
    float movementSpeed = 5f;
    float jumpSpeed = 8f;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-movementSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(movementSpeed, rb.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpSpeed);
        }
    }
}
