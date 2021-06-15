using UnityEngine;

public abstract class IEnemyCollisionEffect : ScriptableObject
{
    public abstract void OnPlayerCollision(Enemy enemy, Player player);
}
