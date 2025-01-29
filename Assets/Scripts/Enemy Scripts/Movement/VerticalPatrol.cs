using UnityEngine;

public class VerticalPatrol : MonoBehaviour, IPatrol
{
    public float speed = 2f;
    public float patrolDistance = 3f;
    private Vector2 startPosition;
    private int direction = 1; // 1 = up, -1 = down

    void Start()
    {
        startPosition = transform.position; // Store original position
    }

    public void Patrol()
    {
        transform.position += new Vector3(0, speed * direction * Time.deltaTime, 0);

        // Reverse direction when reaching patrol limits
        if (Mathf.Abs(transform.position.y - startPosition.y) >= patrolDistance)
        {
            direction *= -1;
        }

        // Adjust rotation to face movement direction (up/down)
        float angle = direction == 1 ? 0f : 180f; // Face upward when moving up, downward when moving down
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
