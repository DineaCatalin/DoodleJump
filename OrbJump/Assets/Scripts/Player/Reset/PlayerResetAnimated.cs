using UnityEngine;

[CreateAssetMenu(menuName = "Player/Reset")]
public class PlayerResetAnimated : IPlayerReset
{
    public Vector2 resetPosition;
    public override void Reset(Player player)
    {
        player.transform.position = resetPosition;
        player.Rigidbody.simulated = true;
        player.gameObject.SetActive(true);
        player.ActiveGraphics.SetActive(true);
        player.TransitionParticles.Play();
    }
}
