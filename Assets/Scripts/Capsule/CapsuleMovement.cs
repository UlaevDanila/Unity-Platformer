using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private float _verticalInput;
    private float _horizontalInput;

    private Vector2 _direction;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");

        _direction.x = _horizontalInput;
        _direction.y = _verticalInput;


    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = _direction * _movementSpeed;
    }
}
