using UnityEngine;

public abstract class IPlayerJump : ScriptableObject
{
    public abstract void Jump(Player player, float jumpPower);
}
