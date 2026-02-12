using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        // Destroy the bullet after 2 seconds to keep the game clean
        Destroy(gameObject, 2f);
        
        // Optional: Force color to Yellow if Inspector is glitchy
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    void Update()
    {
        // Move the projectile to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // If it hits an enemy, the Enemy script handles the destruction
        // If it hits a wall or something else, destroy the bullet
        if (!other.CompareTag("Player")) 
        {
             // We don't destroy immediately here to let the Enemy script handle the logic
             // But usually, we destroy the bullet upon impact
        }
    }
}