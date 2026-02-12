using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float baseSpeed = 5f;
    private float timer = 0f;

    void Update()
    {
        // Increase timer every frame
        timer += Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(x, y);

        // Calculate speed: Base Speed + (Time * 0.3)
        // Example: After 10 seconds, speed adds +3.0
        float currentSpeed = baseSpeed + (timer * 0.3f);

        transform.Translate(move * currentSpeed * Time.deltaTime);
    }
}