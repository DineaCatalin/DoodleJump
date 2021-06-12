using UnityEngine;

public class Platform : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private IPlatformInteraction _interaction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals(PLAYER_TAG) && collision.relativeVelocity.y <= 0f)
        {
            var player = collision.gameObject.GetComponent<Player>();
            _interaction.OnLanded(player);
        }
    }
}
