
using UnityEngine;

public class CollectibleDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Collectible"))
        {
            Debug.Log("Recolectable detectado: " + other.gameObject.name);
        }
    }
}
