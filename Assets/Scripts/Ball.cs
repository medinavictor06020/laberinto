using UnityEngine;

public class Ball : MonoBehaviour
{
    public float maxSpeed = 20f;
    private Rigidbody rb;
    private float originY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.constraints = RigidbodyConstraints.FreezeRotationZ;

        originY = transform.localPosition.y;
    }

    void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
    /*
    void LateUpdate()
    {
        Vector3 localPos = transform.localPosition;
        localPos.y = originY;
        transform.localPosition = localPos;
    }
    */
}