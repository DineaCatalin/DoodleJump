using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private float                 _attackDistance;
    [SerializeField] private IEnemyMovement        _movement;
    [SerializeField] private IEnemyCollisionEffect _collisionEffect;

    [SerializeField] private Collider2D     _collider;
    [SerializeField] private ParticleSystem _graphics;
    [SerializeField] private ParticleSystem _onCollisionParticles;
    
    private Transform  _player;

    private void OnEnable()
    {
        _collider.enabled = true;
    }

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag(PLAYER_TAG).transform;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, _player.position) <= _attackDistance)
        {
            _movement.Move(transform, _player, Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals(PLAYER_TAG))
        {
            var player = collision.gameObject.GetComponent<Player>();
            _collisionEffect.OnPlayerCollision(this, player);
        }
    }

    public void Hide()
    {
        StartCoroutine(HideCoroutine());
    }

    private IEnumerator HideCoroutine()
    {
        _collider.enabled = false;
        _graphics.Stop();
        _onCollisionParticles.Play();

        while(_onCollisionParticles.IsAlive())
        {
            yield return null;
        }

        gameObject.SetActive(false);
    }
}
