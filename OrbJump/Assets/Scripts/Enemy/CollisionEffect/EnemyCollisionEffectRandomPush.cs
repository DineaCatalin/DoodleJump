using UnityEngine;

[CreateAssetMenu(menuName = "Enemy/Effect/RandomPush")]
public class EnemyCollisionEffectRandomPush : IEnemyCollisionEffect
{
    public  float Force;
    private float _downForce = -1f;

    public override void OnPlayerCollision(Enemy enemy, Player player)
    {
        enemy.Hide();
        var direction = (Random.Range(-1f, 1f) > 0) ? 1 : -1;
        var randomForce = new Vector2(direction * _downForce, _downForce);
        randomForce *= Force;
        player.Dash(randomForce);
    }
}
