using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStartUI : MonoBehaviour
{
    [SerializeField] private GameEvent _onAnimationPreEndEvent;
    [SerializeField] private GameEvent _onAnimationEndEvent;

    [SerializeField] private List<TMP_Text> _textList;
    [SerializeField] private Image          _background;

    [Header("Settings")]
    [SerializeField] private float _fadeDuration;
    [SerializeField] private float _delayBetweenTweens;
    [SerializeField] private Ease  _easeType;
    [SerializeField] private float _minAlpha;
    [SerializeField] private float _maxAlpha;

    private float _currentDelay;
    public void DoAnimation()
    {
        Debug.Log("GameStartUI DoAnimation");
        FadeIn();
        FadeOut();

        Invoke("TriggerAnimationPreEndEvent", _currentDelay);
        Invoke("TriggerAnimationEndEvent", _currentDelay + _fadeDuration / 2);

        _currentDelay = 0;
    }

    private void TriggerAnimationEndEvent()    => _onAnimationEndEvent.Raise();

    private void TriggerAnimationPreEndEvent() => _onAnimationPreEndEvent.Raise();

    private void FadeIn()
    {
        if (_background.color.a == _minAlpha)
        {
            _background.DOFade(_maxAlpha, _fadeDuration).SetEase(_easeType);
            _currentDelay += _delayBetweenTweens;
        }
        for (int i = 0; i < _textList.Count; i++)
        {
            _textList[i].DOFade(_maxAlpha, _fadeDuration).SetEase(_easeType).SetDelay(_currentDelay);
            _currentDelay += _delayBetweenTweens;
        }
    }

    private void FadeOut()
    {
        _background.DOFade(_minAlpha, _fadeDuration).SetEase(_easeType).SetDelay(_currentDelay);
        for (int i = 0; i < _textList.Count; i++)
        {
            _textList[i].DOFade(_minAlpha, _fadeDuration / 2).SetEase(_easeType).SetDelay(_currentDelay);
        }
    }
}
