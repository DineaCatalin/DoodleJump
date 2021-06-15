using UnityEngine;

[CreateAssetMenu(menuName = "Enemy/Movement/Streight")]
public class EnemyMovementStreightLine : IEnemyMovement
{
    public override void Move(Transform enemy, Transform target, float deltaTime)
    {
        var step = movementSpeed * deltaTime;
        enemy.position = Vector2.MoveTowards(enemy.position, target.position, step);
    }
}
