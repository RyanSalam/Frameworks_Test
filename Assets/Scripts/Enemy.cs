using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private MovementComponent movementComponent;

    [Header("Properties")]
    [SerializeField] private float timeToChangeDirection = 5;
    private float currentTime;
    private float currentDirection = 1;

    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToChangeDirection) 
        {
            currentDirection *= -1;
            currentTime = 0;
        }

        movementComponent.SetMovementInput(currentDirection);
    }
}