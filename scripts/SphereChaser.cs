
using UnityEngine;

public class SphereChaser : MonoBehaviour
{
    public Transform target;
    public GameObject obstacle;
    public Material hitMaterial;
    public float moveSpeed = 3f;

    private SphereCollider sphereCollider;
    private Renderer obstacleRenderer;
    private bool obstacleHit = false;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        obstacleRenderer = obstacle.GetComponent<Renderer>();
    }

    void Update()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        direction.y = 0f;

        float distance = moveSpeed * Time.deltaTime;
        Vector3 origin = transform.TransformPoint(sphereCollider.center);

        float scale = Mathf.Max(
            transform.lossyScale.x,
            transform.lossyScale.y,
            transform.lossyScale.z
        );

        float radius = sphereCollider.radius * scale;

        if (Physics.SphereCast(
            origin,
            radius,
            direction,
            out RaycastHit hit,
            distance
        ))
        {
            if (hit.collider.gameObject == obstacle && !obstacleHit)
            {
                obstacleRenderer.material = hitMaterial;
                obstacleHit = true;
                Debug.Log("La esfera ha alcanzado el cubo");
            }

            return;
        }

        transform.position += direction * distance;
    }
}
