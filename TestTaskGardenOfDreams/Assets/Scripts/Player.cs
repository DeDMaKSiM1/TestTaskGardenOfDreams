 using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rb;
    private Vector2 _direction;
     
    private  void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (_direction != Vector2.zero)
            _rb.MovePosition(_rb.position + _speed * Time.fixedDeltaTime * _direction);
        else
            _rb.velocity = Vector2.zero;

    }
    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
        Debug.Log(_direction);
    }
}
