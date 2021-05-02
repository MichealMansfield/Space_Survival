using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableMove : MonoBehaviour
{
    [Header("Floats")]
    public float moveSpeed = 80.0f;

    [Header("Rigidbody")]
    public Rigidbody2D rb;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 movement = Vector2.zero;
        movement.y = (transform.up * Time.deltaTime * -moveSpeed).y;
        movement = movement + (Vector2)(transform.position);
        rb.MovePosition(movement);
    }
}
