using UnityEngine;

[CreateAssetMenu(menuName = "Platform/JumpPlatform")]
public class JumpPlatform : IPlatformInteraction
{
    public float jumpForce;

    public override void OnLanded(Player player) => player.Jump(jumpForce);
}
