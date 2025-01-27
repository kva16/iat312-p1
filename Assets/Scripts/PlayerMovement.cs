using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Vector2 moveInput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");  // A/D or Left/Right Arrow
        moveInput.y = Input.GetAxisRaw("Vertical");    // W/S or Up/Down Arrow
        moveInput.Normalize(); // Prevent diagonal movement from being faster
    }

    void FixedUpdate()
    {
        // Move player using physics-based movement (respects colliders)
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
