using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        Vector2 direction = new Vector2( variableJoystick.Horizontal, variableJoystick.Vertical);
        rb.AddForce(direction * speed * Time.fixedDeltaTime);
    }
}