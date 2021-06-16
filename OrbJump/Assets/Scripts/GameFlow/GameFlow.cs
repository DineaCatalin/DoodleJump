using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameEvent _startGameEvent;
    [SerializeField] private Player    _player;

    private void Start()         => StartGame();

    public void StartGame()
    {
        _startGameEvent.Raise();
    }
}
