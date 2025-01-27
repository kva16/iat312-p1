using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHits = 2; // Player dies after 2 hits
    private int currentHits = 0;

    public void TakeDamage()
    {
        currentHits++;
        Debug.Log("Player hit! Hits taken: " + currentHits);

        if (currentHits >= maxHits)
        {
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        Debug.Log("Player has been killed!");
        Destroy(gameObject); // Remove player from the scene
    }
}
