
using UnityEngine;

public class ColorZone : MonoBehaviour
{
    private Renderer playerRenderer;
    private Color originalColor;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerRenderer = other.GetComponent<Renderer>();

            if (playerRenderer != null)
            {
                originalColor = playerRenderer.material.color;
                playerRenderer.material.color = Color.green;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerRenderer != null)
            {
                playerRenderer.material.color = originalColor;
                playerRenderer = null;
            }
        }
    }
}
