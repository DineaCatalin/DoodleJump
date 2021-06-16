using UnityEngine;

[CreateAssetMenu(menuName = "Player/Death")]
public class PlayerAnimatedDeath : IPlayerDeath
{
    public override void Die(Player player) 
    {
        //TODO
        Debug.Log("PlayerAnimatedDeath Die");
        player.Rigidbody.simulated = false;
        player.DeathParticles.Play();
    } 
}
