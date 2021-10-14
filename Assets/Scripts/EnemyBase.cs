using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private float CharavterVelocity = 2f;
    private Vector2 MovementDirection;
    private Vector2 movementPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }

    void calcuateNewMovementVector()
    {
        MovementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = MovementDirection * CharavterVelocity;
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), transform.position.y + (movementPerSecond.y * Time.deltaTime));
    }
}
