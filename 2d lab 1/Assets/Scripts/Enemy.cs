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
        // Check if the object we hit is the Player
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            // Deal damage
            player.TakeDamage(damage);
            
            // Destroy the enemy so it doesn't hit us twice
            Destroy(gameObject);
        }
    }

    void Update()
    {
        // Destroy object if it goes off-screen to the left
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
