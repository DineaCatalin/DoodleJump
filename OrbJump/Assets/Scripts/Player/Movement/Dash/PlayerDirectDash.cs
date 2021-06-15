using UnityEngine;

[CreateAssetMenu(menuName ="Player/Movement/Dash")]
public class PlayerDirectDash : IPlayerDash
{
    public override void Dash(Player player, Vector2 direction) => player.Rigidbody.velocity = direction;
}
