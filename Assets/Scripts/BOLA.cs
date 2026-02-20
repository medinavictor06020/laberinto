using UnityEngine;


public class BallController : MonoBehaviour
{
    public float maxSpeed = 2000f;


    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        // Limitar velocidad máxima
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
