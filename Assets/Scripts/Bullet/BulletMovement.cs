using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float _velocity;

    [SerializeField] private float _destroyDistance;

    private float _horizontalOffset;

    private float _verticalOffset;

    private Vector3 _startPosition;
    private Vector3 _currentPosition;

    private Rigidbody2D _rigidbody;

    private Vector2 _direction;

    private void Start()
    {
        _startPosition = GetComponent<Transform>().position;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _horizontalOffset = Screen.width / 2;

        _verticalOffset = Screen.height / 2;
    }

    private void Update()
    {
        _currentPosition = transform.position;

        _direction.x = Input.mousePosition.x - _horizontalOffset;
        _direction.y = Input.mousePosition.y - _verticalOffset;

        if(Vector3.Distance(_startPosition, _currentPosition) > _destroyDistance)
        {
            Destroy(gameObject);
        }
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = _direction.normalized * _velocity;
    }
}
