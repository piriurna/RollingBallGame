using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallMovementController : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);

    [SerializeField] private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        movement.x = movementValue.Get<Vector2>().x;
        movement.z = movementValue.Get<Vector2>().y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(movement * speed);
    }
}
