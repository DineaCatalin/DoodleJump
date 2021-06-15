using UnityEngine;

public abstract class IInteractable : ScriptableObject
{
    [SerializeField] private GameEvent _onInteractionEvent;

    public virtual void RaiseInteractionEvent() => _onInteractionEvent?.Raise();

}
