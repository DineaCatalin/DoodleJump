using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private const string DESTOYABLE_OBJECTS_TAG = "Destroyable";
    private const string PLAYER_TAG             = "Player";

    [SerializeField] private GameEvent _playerDeathEvent;
    [SerializeField] private float     _yOffset;

    private void Awake()
    {
        var screenBottomCenter = new Vector3(Screen.width / 2, 0, 0);
        var position = Camera.main.ScreenToWorldPoint(screenBottomCenter);
        position.y += _yOffset;
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(DESTOYABLE_OBJECTS_TAG))
        {
            collision.gameObject.SetActive(false);
        }
        else if(collision.tag.Equals(PLAYER_TAG))
        {
            _playerDeathEvent.Raise();
        }
    }
}
