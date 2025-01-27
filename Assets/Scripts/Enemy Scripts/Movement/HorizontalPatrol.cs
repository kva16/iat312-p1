using UnityEngine;

public class HorizontalPatrol : MonoBehaviour, IPatrol
{
    public float speed = 2f;
    public float patrolDistance = 3f; // Max movement distance from start
    private Vector2 startPosition;
    private int direction = 1; // 1 = right, -1 = left

    void Start()
    {
        startPosition = transform.position; // Store original position
    }

    public void Patrol()
    {
        transform.position += new Vector3(speed * direction * Time.deltaTime, 0, 0);

        // Reverse direction when reaching patrol limits
        if (Mathf.Abs(transform.position.x - startPosition.x) >= patrolDistance)
        {
            direction *= -1;
        }
    }
}
