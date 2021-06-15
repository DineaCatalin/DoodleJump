using UnityEngine;

public abstract class IPlayerDeath : ScriptableObject
{
    public abstract void Die(Player player);
}