using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Platform/Movement/Streight")]
public class PlatformStreightMovement : IPlatformMovement
{
    public override void Move(Transform transform, Vector3 destination, float deltaTime)
    {
        var step = movementSpeed * deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }
}
