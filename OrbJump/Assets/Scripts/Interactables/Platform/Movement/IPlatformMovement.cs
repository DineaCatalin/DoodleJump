using UnityEngine;

public abstract class IPlatformMovement : ScriptableObject
{
    public float movementSpeed;
    public float distanceDeltaChangeWaypoint;

    public abstract void Move(Transform transform, Vector3 destination, float deltaTime);
}
