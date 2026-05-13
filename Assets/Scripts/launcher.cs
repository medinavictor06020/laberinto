using System;
using UnityEngine;
public class Launcher : MonoBehaviour
{
    public float launchForce = 800f;
    public GameObject ball;
    private Boolean active = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && active == true)
        {
            active = false;
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * launchForce, ForceMode.Impulse);
        }
    }
}