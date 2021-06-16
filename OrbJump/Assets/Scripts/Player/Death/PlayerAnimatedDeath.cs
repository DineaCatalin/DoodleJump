using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/Death")]
public class PlayerAnimatedDeath : IPlayerDeath
{
    public override void Die(Player player) 
    {
        player.DeathParticles.Play();
        player.Rigidbody.simulated = false;
        player.ActiveGraphics.SetActive(false);

        DOVirtual.DelayedCall(2f, () =>
        {
            player.transform.position = Vector2.zero;
        });
    } 
}
