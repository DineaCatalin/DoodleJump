using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEndUI : GameScreenFade
{
    [SerializeField] private float     _animationDelay;
    [SerializeField] private float     _retryEventDelay;

    [SerializeField] private string    _highScoreText;
    [SerializeField] private string    _noHighScoreText;
    [SerializeField] private TMP_Text  _descriptionText;
    [SerializeField] private TMP_Text  _currentScoreValueText;
    [SerializeField] private TMP_Text  _highScoreValueText;

    [SerializeField] private GameEvent _retryEvent;
    [SerializeField] private Score     _score;

    [SerializeField] private List<Button> _buttons;
    
    public void DoDelayedAnimation() => Invoke("DoAnimation", _animationDelay);
    
    public void TriggerRetryEvent() => _retryEvent?.Raise();
    public override void DoAnimation()
    {
        Debug.Log("GameEndUI DoAnimation");
        ConfigureScore();
        FadeIn();
        Invoke("ActivateButtons", _currentDelay / 2);
        Reset();
    }

    private void Awake() => SetButtonsActive(false);
    public void Retry()
    {
        FadeOutText();
        Reset();
        Invoke("TriggerRetryEvent", _retryEventDelay);
        SetButtonsActive(false);
    } 
    public void Quit() => Application.Quit();

    private void ConfigureScore()
    {
        if(_score.NewHighScore)
        {
            _descriptionText.text = _highScoreText;
        }
        else
        {
            _descriptionText.text = _noHighScoreText;
        }

        _currentScoreValueText.text = Mathf.Round(_score.CurrentScore).ToString();
        _highScoreValueText.text     = Mathf.Round(_score.HighScore).ToString();
    }

    private void SetButtonsActive(bool active) => _buttons.ForEach(button => button.gameObject.SetActive(active));

    private void ActivateButtons()             => SetButtonsActive(true);
}
