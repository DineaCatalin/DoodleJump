using UnityEngine;

[CreateAssetMenu(menuName ="Platform/Interaction/Destroyable")]
public class DestroyablePlatform : IPlatformInteraction
{
    public override void OnLanded(Player player, Platform platform)
    {
        platform.Hide();
        player.LandlingParticles.Play();
        RaiseInteractionEvent();
    }
}
