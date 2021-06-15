using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Score       _score;
    [SerializeField] private TMP_Text    _scoreText;

    [SerializeField] private IntVariable _platformsTouchedCounter;
    [SerializeField] private TMP_Text    _platformCounterText;

    private float _previousScore;
    private float _previousPlatformCounter;

    private void Update()
    {
        UpdateScore();
        UpdateCounter();
    }

    private void UpdateScore()
    {
        if (_score.CurrentScore != _previousScore)
        {
            _scoreText.text = Mathf.Round(_score.CurrentScore).ToString();
            _previousScore = _score.CurrentScore;
        }
    }

    private void UpdateCounter()
    {
        if(_platformsTouchedCounter.Value != _previousPlatformCounter)
        {
            _platformCounterText.text = _platformsTouchedCounter.Value.ToString();
            _previousPlatformCounter = _platformsTouchedCounter.Value;
        }
    }
}
