
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    public float launchForce = 20f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(Vector3.right * launchForce, ForceMode.Impulse);
        }
    }
}
