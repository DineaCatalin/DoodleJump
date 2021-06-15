using UnityEngine;

public abstract class IPlayerDash : ScriptableObject
{
    public abstract void Dash(Player player, Vector2 direction);
}
