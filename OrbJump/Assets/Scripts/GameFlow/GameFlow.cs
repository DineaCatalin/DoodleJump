using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameEvent _startLevelEvent;

    private void Start()     => StartLevel();

    public void StartLevel() => _startLevelEvent.Raise();

    //Test  
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartLevel();
        }
    }
}
