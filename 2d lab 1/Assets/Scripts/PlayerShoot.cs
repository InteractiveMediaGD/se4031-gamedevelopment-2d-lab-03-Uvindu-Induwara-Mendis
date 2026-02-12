using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Update()
    {
        // Check for Left Mouse Button (0)
        if (Input.GetMouseButtonDown(0))
        {
            // Create a projectile at the player's position
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
