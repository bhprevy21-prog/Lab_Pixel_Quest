using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
    }

    void Update()
    {
        // Get input for horizontal (A/D, Left/Right Arrow) and vertical (W/S, Up/Down Arrow) axes
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        // Normalize the movement vector to prevent faster diagonal movement
        if (movement.sqrMagnitude > 5)
        {
            movement.Normalize();
        }
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody2D using velocity
        rb.velocity = movement * moveSpeed;
    }
}