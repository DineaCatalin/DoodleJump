using UnityEngine;

public class GameStartUI : GameScreenFade
{
    [SerializeField] private GameEvent _onAnimationPreEndEvent;
    [SerializeField] private GameEvent _onAnimationEndEvent;
    public override void DoAnimation()
    {
        FadeIn();
        FadeOutBackground();
        FadeOutText();

        Invoke("TriggerAnimationPreEndEvent", _currentDelay);
        Invoke("TriggerAnimationEndEvent", _currentDelay + _fadeDuration / 2);

        Reset();
    }

    private void TriggerAnimationEndEvent()    => _onAnimationEndEvent.Raise();

    private void TriggerAnimationPreEndEvent() => _onAnimationPreEndEvent.Raise();
}
