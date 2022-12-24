using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float _velocity;

    [SerializeField] private float _destroyDistance;

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
    }

    private void Update()
    {
        _currentPosition = transform.position;

        _direction.x = Input.mousePosition.x;
        _direction.y = Input.mousePosition.y;

        if(Vector3.Distance(_startPosition, _currentPosition) > _destroyDistance)
        {
            Destroy(gameObject);
        }

        Debug.Log((Input.mousePosition.x, Input.mousePosition.y));
    }


    private void FixedUpdate()
    {
        _rigidbody.velocity = _direction.normalized * _velocity;
    }
}
