using UnityEngine;

[CreateAssetMenu(menuName = "Player/Death")]
public class PlayerAnimatedDeath : IPlayerDeath
{
    public override void Die(Player player) 
    {
        player.Rigidbody.simulated = false;
        player.DeathParticles.Play();
    } 
}
