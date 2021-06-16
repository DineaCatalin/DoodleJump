using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class GameScreenFade : MonoBehaviour
{
    [SerializeField] private List<TMP_Text> _textList;
    [SerializeField] private Image          _background;

    [Header("Tweening Settings")]
    [SerializeField] protected float _fadeDuration;
    [SerializeField] private float   _delayBetweenTweens;
    [SerializeField] private Ease    _easeType;
    [SerializeField] private float   _minAlpha;
    [SerializeField] private float   _maxAlpha;

    protected float _currentDelay;

    public abstract void DoAnimation();
    protected void FadeIn()
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

    protected void Reset()             => _currentDelay = 0;
    protected void FadeOutBackground() => _background.DOFade(_minAlpha, _fadeDuration).SetEase(_easeType).SetDelay(_currentDelay);
    protected void FadeOutText()
    {
        for (int i = 0; i < _textList.Count; i++)
        {
            _textList[i].DOFade(_minAlpha, _fadeDuration / 2).SetEase(_easeType).SetDelay(_currentDelay);
        }
    }

}
