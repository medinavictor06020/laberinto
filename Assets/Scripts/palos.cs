using UnityEngine;


public class Flipper : MonoBehaviour
{
    public KeyCode key;               // Tecla asignada
    public float pressedAngle = 45f;  // Ángulo cuando se pulsa
    public float restAngle = -20f;    // Ángulo de reposo
    public float strength = 1000f;    // Fuerza del motor
    public float damper = 10f;


    private HingeJoint hinge;


    void Start()
    {
        hinge = GetComponent<HingeJoint>();
        JointSpring spring = hinge.spring;
        spring.spring = strength;
        spring.damper = damper;
        hinge.spring = spring;
        hinge.useSpring = true;
    }


    void Update()
    {
        JointSpring spring = hinge.spring;


        if (Input.GetKey(key))
            spring.targetPosition = pressedAngle;
        else
            spring.targetPosition = restAngle;


        hinge.spring = spring;
    }
}


