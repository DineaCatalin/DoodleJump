using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rigidbody => _rigidbody;
    public Collider2D  Collider  => _collider;

    public GameObject     ActiveGraphics;
    public GameObject     RocketGraphics;
    public ParticleSystem TransitionGraphics;

    [SerializeField] private PlayerRocket _rocket;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D  _collider;

    [SerializeField] private IInputService   _inputService;
    [SerializeField] private IPlayerMovement _movement;
    [SerializeField] private IPlayerJump     _jump;

    private void FixedUpdate()           => Move();

    public void Jump(float jumpPower)    => _jump.Jump(this, jumpPower);

    public void ActivateRocket()         => _rocket.Activate();

    public void Move()                   => _movement.Move(this);

    public float GetHorizontalMovement() => _inputService.GetDirection();
}
