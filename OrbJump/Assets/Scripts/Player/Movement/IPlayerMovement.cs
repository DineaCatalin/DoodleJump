using UnityEngine;

public abstract class IPlayerMovement : ScriptableObject
{
    public float movementSpeed;

    public abstract void Move(Player player);
}
