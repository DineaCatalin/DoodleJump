using UnityEngine;

[CreateAssetMenu(menuName = "Enemy/Effect/RandomPush")]
public class EnemyCollisionEffectRandomPush : IEnemyCollisionEffect
{
    public  float Force;
    private float _downForce = -1f;

    public override void OnPlayerCollision(Enemy enemy, Player player)
    {
        enemy.Hide();
        var randomForce = new Vector2(Random.Range(-1f, 1f), _downForce);
        Debug.Log($"randomForce before mul {randomForce}");
        randomForce *= Force;
        player.Dash(randomForce);
        Debug.Log($"Player Dashing with {randomForce}");
    }
}
