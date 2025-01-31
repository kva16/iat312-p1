using UnityEngine;

public class SpiderFollowAfterCollision : MonoBehaviour
{
    private Transform player; // Reference to the player's transform
    public float followSpeed = 3f; // Speed at which the spider follows the player
    private bool isFollowing = false; // Whether the spider is currently following the player

    void Start()
    {
        // Automatically find the player by tag
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the player is tagged as 'Player'.");
        }
    }

    void Update()
    {
        if (isFollowing && player != null)
        {
            // Move the spider towards the player
            transform.position = Vector2.MoveTowards(transform.position, player.position, followSpeed * Time.deltaTime);
        }
    }

    // Detect collision with the player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with the spider!");
            isFollowing = true; // Start following the player
        }
    }

    // Alternatively, use this if you want to detect trigger collisions
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player triggered the spider!");
            isFollowing = true; // Start following the player
        }
    }
}