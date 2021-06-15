using UnityEngine;

public abstract class IItemBehaviour : IInteractable
{
    public bool HideOnInteraction;
    public abstract void OnPickUp(Player player, Item item);
}
