
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int damage = 0;
    public int damageIncrease = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            damage += damageIncrease;

            Debug.Log("Daño actual: " + damage);
        }
    }
}
