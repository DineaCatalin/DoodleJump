using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameEvent _startGameEvent;
    [SerializeField] private Player    _player;

    private void Start()         => StartGame();

    public void StartGame()
    {
        Debug.Log("GameFlow StartGame");
        _startGameEvent.Raise();
    }

    //Test  
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartGame();
        }
    }
}
