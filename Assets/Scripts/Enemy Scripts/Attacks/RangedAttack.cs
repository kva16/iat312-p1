using UnityEngine;

public class RangedAttack : EnemyAI
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float attackCooldown = 2f;
    private float lastAttackTime = 0f;

    public override void Attack()
    {
        if (Time.time - lastAttackTime > attackCooldown)
        {
            Debug.Log(gameObject.name + " is shooting at the player!");

            if (firePoint == null || projectilePrefab == null)
            {
                Debug.LogError("FirePoint or ProjectilePrefab not assigned in RangedAttack!");
                return;
            }

            // Calculate direction to the player
            Vector2 direction = (player.position - firePoint.position).normalized;

            // Spawn the projectile and set its direction
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            projectile.GetComponent<Projectile>().SetDirection(direction);

            lastAttackTime = Time.time;
        }
    }
}
