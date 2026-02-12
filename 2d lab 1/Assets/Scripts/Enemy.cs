using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 20;

    // This function runs once when the game starts
    void Start()
    {
        // FORCE the color to be Red via code!
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if hit by a Projectile
        if (other.CompareTag("Projectile"))
        {
            // Add Score
            FindObjectOfType<ScoreManager>().AddScore(5);
            
            // Destroy the bullet
            Destroy(other.gameObject);
            
            // Destroy this enemy
            Destroy(gameObject);
            return; // Exit the function so we don't check for Player collision
        }

        // Check if hit by the Player
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
