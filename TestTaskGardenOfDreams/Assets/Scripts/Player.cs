using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rbody;
    private Vector2 _direction;
    private Animator _animator;

    private const string IsWalking = "IsWalking";
    private const string HorizontalMovementValue = "HorizontalMovement";
    private void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (_direction != Vector2.zero)
        {
            _rbody.MovePosition(_rbody.position + _speed * Time.fixedDeltaTime * _direction);
            MoveAnimationCheck();
        }
        else
        {
            _rbody.velocity = Vector2.zero;
            _animator.SetBool(IsWalking, false);
        }

    }
    public void SetDirection(Vector2 direction)
    {
        _direction = direction; 
    }
    private void MoveAnimationCheck()
    {
        _animator.SetBool(IsWalking, true); 
        _animator.SetFloat(HorizontalMovementValue, _direction.x);
    }
}
