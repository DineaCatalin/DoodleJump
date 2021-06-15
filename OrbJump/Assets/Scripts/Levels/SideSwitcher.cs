using UnityEngine;

public class SideSwitcher : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField]  private SideSwitcher _otherSide;

    [HideInInspector] public float XPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(PLAYER_TAG))
        {
            var position = collision.transform.position;
            collision.transform.position = new Vector2(_otherSide.XPosition, collision.transform.position.y);
        }
    }
}
