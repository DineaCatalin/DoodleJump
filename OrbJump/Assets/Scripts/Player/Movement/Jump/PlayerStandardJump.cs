using UnityEngine;

[CreateAssetMenu(menuName = "Player/Jump")]
public class PlayerStandardJump : IPlayerJump
{
    public override void Jump(Player player, float jumpForce)
    {
        var velocity = player.Rigidbody.velocity;
        velocity.y = jumpForce;
        player.Rigidbody.velocity = velocity;
    }
}
