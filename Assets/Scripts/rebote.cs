using UnityEngine;


public class Bumper : MonoBehaviour
{
    public float force = 500f;
    public int points = 100;


    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;


        if (rb != null)
        {
            // Empuje hacia afuera
            Vector3 dir = collision.contacts[0].normal;
            rb.AddForce(-dir * force);
        }


        // Sumar puntos
        ScoreManager.Instance.AddPoints(points);
    }
}

