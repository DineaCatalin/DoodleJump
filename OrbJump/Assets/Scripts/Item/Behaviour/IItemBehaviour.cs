using UnityEngine;

public abstract class IItemBehaviour : ScriptableObject
{
    public abstract void OnPickUp(Player player, Item item);
}
