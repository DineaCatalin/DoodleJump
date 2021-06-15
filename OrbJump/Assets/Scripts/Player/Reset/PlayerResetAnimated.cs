using UnityEngine;

[CreateAssetMenu(menuName = "Player/Reset")]
public class PlayerResetAnimated : IPlayerReset
{
    public Vector2 resetPosition;

    public override void Reset(Player player)
    {
        player.transform.position = resetPosition;
        player.TransitionParticles.Play();
    }
}
