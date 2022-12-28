using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;

    private Transform _characterTransform;

    private float _horizontalInput;


    private void Awake()
    {
        _characterTransform= GetComponent<Transform>();

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _horizontalInput = Input.GetAxis("Horizontal");
            if(_horizontalInput >= 0)
            {
                var _bulletPosition = _characterTransform.position.x + _characterTransform.localScale.x / 2 + _bullet.GetComponent<Transform>().localScale.x / 2;

                Instantiate(_bullet, new Vector3(_bulletPosition, _characterTransform.position.y, 0), Quaternion.identity);
            }

            else
            {
                var _bulletPosition = _characterTransform.position.x - _characterTransform.localScale.x / 2 - _bullet.GetComponent<Transform>().localScale.x / 2;

                Instantiate(_bullet, new Vector3(_bulletPosition, _characterTransform.position.y, 0), Quaternion.identity);
            }
            

        }
    }
}
