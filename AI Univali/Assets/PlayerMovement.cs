using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }

        Move();
    }

    void Move()
    {
        transform.position =
            new Vector2(transform.position.x + (direction.x * movementSpeed * Time.deltaTime),
            transform.position.y + (direction.y * movementSpeed * Time.deltaTime));
    }
}
