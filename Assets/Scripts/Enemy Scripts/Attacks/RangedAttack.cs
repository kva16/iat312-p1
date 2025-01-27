using UnityEngine;

public class RangedAttack : MonoBehaviour, IEnemyAttack
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float attackCooldown = 2f;
    private float lastAttackTime = 0f;
    private Transform player;
    public float attackRange = 5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player == null)
        {
            Debug.LogError("Player not found! Make sure the Player GameObject has the 'Player' tag.");
        }
    }

    void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        
        // If player is within range, attack
        if (distanceToPlayer <= attackRange)
        {
            Attack();
        }
    }

    public void Attack()
    {
        if (Time.time - lastAttackTime > attackCooldown)
        {
            Debug.Log(gameObject.name + " is shooting at the player!");

            // Calculate direction to the player
            Vector2 direction = (player.position - firePoint.position).normalized;

            // Spawn the projectile and set its direction
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            projectile.GetComponent<Projectile>().SetDirection(direction);

            lastAttackTime = Time.time;
        }
    }
}
