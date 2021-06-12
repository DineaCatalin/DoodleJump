using UnityEngine;

public class Player : MonoBehaviour
{
    public IInputService InputService => _inputService;
    public Rigidbody2D Rigidbody => _rigidbody;

    [SerializeField] private IInputService _inputService;
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private IPlayerMovement _movement;
    [SerializeField] private IPlayerJump _jump;

    private void FixedUpdate()
    {
        _movement.Move(this);
    }

    public void Jump(float jumpPower) => _jump.Jump(this, jumpPower);
}
