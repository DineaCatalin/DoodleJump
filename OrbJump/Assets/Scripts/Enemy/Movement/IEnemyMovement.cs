using UnityEngine;

public abstract class IEnemyMovement : ScriptableObject
{
    public float movementSpeed;

    public abstract void Move(Transform enemy, Transform target, float deltaTime);
}
