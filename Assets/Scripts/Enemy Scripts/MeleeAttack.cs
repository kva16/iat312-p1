using UnityEngine;

public class MeleeAttack : MonoBehaviour, IEnemyAttack
{
    public float attackCooldown = 1f;
    private float lastAttackTime = 0f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Attack(collision.gameObject);  // Call attack with player reference
        }
    }

    // Implementing the interface-required method
    public void Attack()
{
    if (GameObject.FindGameObjectWithTag("Player") != null)
    {
        Attack(GameObject.FindGameObjectWithTag("Player"));
    }
    else
    {
        Debug.LogWarning("MeleeAttack: No target found!");
    }
}


    // This is the actual attack logic with a player reference
    public void Attack(GameObject player)
    {
        if (Time.time - lastAttackTime > attackCooldown)
        {
            Debug.Log(gameObject.name + " is attacking the player with Melee!");
            lastAttackTime = Time.time;

            // Kill the player
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.KillPlayer();
            }
            else
            {
                Debug.LogError("PlayerHealth script not found on Player!");
            }
        }
    }
}
