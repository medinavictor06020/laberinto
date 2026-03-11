using UnityEngine;


public class Launcher : MonoBehaviour
{
    public float launchForce = 800f;
    private bool charging = false;
    private float charge = 0f;
    public float maxCharge = 1f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            charging = true;


        if (Input.GetKey(KeyCode.Space))
            charge = Mathf.Clamp(charge + Time.deltaTime, 0, maxCharge);


        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody rb = GetComponentInChildren<Rigidbody>();
            rb.AddForce(Vector3.forward * launchForce * charge);
            charge = 0;
            charging = false;
        }
    }
}


