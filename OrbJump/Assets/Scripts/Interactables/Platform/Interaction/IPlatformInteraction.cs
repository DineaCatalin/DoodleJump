using UnityEngine;

public abstract class IPlatformInteraction : IInteractable
{
    public abstract void OnLanded(Player player, Platform platform);

}