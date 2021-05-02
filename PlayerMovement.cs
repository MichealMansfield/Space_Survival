using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Floats")]
    public float moveSpeed = 125.0f;

    [Header("Rigidbody")]
    public Rigidbody2D rb;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = (transform.right * Time.deltaTime * -moveSpeed).x;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement.x = (transform.right * Time.deltaTime * moveSpeed).x;
        }

        movement = movement + (Vector2)(transform.position);
        rb.MovePosition(movement);
    }
}
