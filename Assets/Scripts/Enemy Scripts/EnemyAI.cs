using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 2f;
    public float chaseRange = 5f;
    public float attackRange = 1f;
    private Transform player;
    private bool isChasing = false;

    private IEnemyAttack attackBehavior; // Interface for attacks

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the Player GameObject has the 'Player' tag.");
        }

        // Get attack behavior (if assigned)
        attackBehavior = GetComponent<IEnemyAttack>();
    }

    void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseRange)
            isChasing = true;
        else if (distanceToPlayer > chaseRange * 1.5f)
            isChasing = false;

        if (isChasing)
            ChasePlayer();

        // Attack if close to the player
        if (distanceToPlayer < attackRange && attackBehavior != null)
            attackBehavior.Attack();
    }

    void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}
