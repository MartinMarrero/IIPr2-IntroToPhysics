
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He colisionado con: " + collision.gameObject.name);

        objectRenderer.material.color = Random.ColorHSV();
    }
}
