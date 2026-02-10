using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public int healAmount = 20;

    // This function runs automatically when the game starts
    void Start()
    {
        // FORCE the color to be Green via code!
        GetComponent<SpriteRenderer>().color = Color.green;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            player.currentHealth = Mathf.Min(player.currentHealth + healAmount, player.maxHealth);
            player.SendMessage("UpdateUI", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
