using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private Score _score;
    [SerializeField] private float _scoreMultiplier;

    private Transform _player;

    private void Awake()        => _score.LoadHighScore();

    private void Start()        => _player = GameObject.FindGameObjectWithTag(PLAYER_TAG).transform;

    private void Update()       => UpdateScore();

    private void OnDestroy()    => _score.SaveHighScore();

    public void Reset()         => _score.Reset();

    public void SaveHighScore() => _score.SaveScore();

    private void UpdateScore()
    {
        var potentialScore = GetScoreFromPosition(_player.transform.position.y);
        if(potentialScore > _score.CurrentScore)
        {
            _score.CurrentScore = potentialScore;
        }
    }

    private float GetScoreFromPosition(float posY) => posY * _scoreMultiplier;
}
