using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody rb;

    [Header("Properties")]
    [SerializeField] private float speed = 5;

    private float movementInput;

    private void FixedUpdate()
    {
        Vector3 translation = Vector3.right * movementInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + translation);
    }

    public void SetMovementInput(float newValue) 
    {
        movementInput = newValue;
    }
}
