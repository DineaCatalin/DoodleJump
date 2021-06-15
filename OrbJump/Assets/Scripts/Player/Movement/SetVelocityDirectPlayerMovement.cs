using UnityEngine;

[CreateAssetMenu(menuName ="Player/Movement")]
public class SetVelocityDirectPlayerMovement : IPlayerMovement
{
    public override void Move(Player player)
    {
        var rb = player.Rigidbody;
        var movementDirection = player.GetHorizontalMovement() * movementSpeed;

        rb.velocity = new Vector2(movementDirection, rb.velocity.y);
    }
}
