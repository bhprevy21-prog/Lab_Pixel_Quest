using UnityEngine;

public class TeleportOnCollision : MonoBehaviour
{
    // The specific location where you want to teleport
    public Vector2 targetPosition;

    // Tag of the sprite that triggers teleportation
    public string triggerTag = "Teleporter";

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the correct tag
        if (other.CompareTag(triggerTag))
        {
            // Teleport this object to the target position
            transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);

            Debug.Log("Teleported to: " + targetPosition);
        }
    }
}
