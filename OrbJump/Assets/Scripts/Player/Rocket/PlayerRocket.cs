using UnityEngine;

public class PlayerRocket : MonoBehaviour
{
    [SerializeField] private RocketData _rocketData;
    [SerializeField] private Player _player;

    private void Start() => this.enabled = false;

    private void Update() => _player.Jump(_rocketData.speed);

    public void Activate()
    {
        this.enabled = true;

        _player.TransitionParticles.Play();

        _player.ActiveGraphics.SetActive(false);
        _player.RocketGraphics.SetActive(true);

        Invoke("Deactivate", _rocketData.duration);
    }

    private void Deactivate()
    {
        _player.TransitionParticles.Play();

        _player.ActiveGraphics.SetActive(true);
        _player.RocketGraphics.SetActive(false);

        //_player.Rigidbody.velocity = Vector2.zero;

        this.enabled = false;
    }
}