using UnityEngine;

public abstract class IItemBehaviour : ScriptableObject
{
    public bool HideOnInteraction;
    public abstract void OnPickUp(Player player, Item item);
}
