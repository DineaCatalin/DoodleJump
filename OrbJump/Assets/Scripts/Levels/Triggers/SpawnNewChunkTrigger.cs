using UnityEngine;

public class SpawnNewChunkTrigger : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private LevelManager _levelManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(PLAYER_TAG))
        {
            _levelManager.ShowNextChunk();
        }
    }
}
