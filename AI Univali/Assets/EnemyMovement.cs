using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    Transform playerPosition;
    float currentSpeed;
    State myState;

    private void Start()
    {
        myState = GetComponent<State>();
        currentSpeed = movementSpeed;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        SetCurrentSpeed();
        Move();
    }

    void SetCurrentSpeed()
    {
        switch (myState.GetEntetyState())
        {
            case state.IDLE:
                currentSpeed = 0;
                break;
            case state.RUNOVER:
                currentSpeed = movementSpeed;
                break;
            case state.COMBAT:
                currentSpeed = 0;
                break;
            case state.RUNOFF:
                currentSpeed = -movementSpeed;
                break;
        }
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, currentSpeed);
    }
}
