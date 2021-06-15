using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rigidbody => _rigidbody;
    public Collider2D Collider => _collider;

    public GameObject ActiveGraphics;
    public GameObject RocketGraphics;
    public ParticleSystem TransitionParticles;
    public ParticleSystem LandlingParticles;
    public ParticleSystem DeathParticles;

    [SerializeField] private PlayerRocket _rocket;

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Collider2D  _collider;

    [SerializeField] private IInputService   _inputService;
    [SerializeField] private IPlayerMovement _movement;
    [SerializeField] private IPlayerJump     _jump;
    [SerializeField] private IPlayerDash     _dash;
    [SerializeField] private IPlayerDeath    _death;
    [SerializeField] private IPlayerReset    _reset;

    private void Start()                 => ResetPlayer();

    private void FixedUpdate()           => Move();

    public void Jump(float jumpPower)    => _jump.Jump(this, jumpPower);

    public void Dash(Vector2 direction)  => _dash.Dash(this, direction);

    public void ActivateRocket()         => _rocket.Activate();

    public void Move()                   => _movement.Move(this);

    public float GetHorizontalMovement() => _inputService.GetDirection();

    public void Die()                    => _death.Die(this);

    public void ResetPlayer()            => _reset.Reset(this);
}
