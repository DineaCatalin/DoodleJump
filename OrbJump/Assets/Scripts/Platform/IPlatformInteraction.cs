using UnityEngine;

public abstract class IPlatformInteraction : ScriptableObject
{
    public abstract void OnLanded(Player player);
}