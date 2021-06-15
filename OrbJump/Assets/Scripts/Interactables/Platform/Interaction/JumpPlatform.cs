using UnityEngine;

[CreateAssetMenu(menuName = "Platform/Interaction/JumpPlatform")]
public class JumpPlatform : IPlatformInteraction
{
    public float jumpForce;

    public override void OnLanded(Player player, Platform platform)
    {
        player.Jump(jumpForce);
        player.LandlingParticles.Play();
    }
}
