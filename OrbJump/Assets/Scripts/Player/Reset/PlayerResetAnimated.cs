﻿using UnityEngine;

[CreateAssetMenu(menuName = "Player/Reset")]
public class PlayerResetAnimated : IPlayerReset
{
    public Vector2 resetPosition;

    public override void Reset(Player player)
    {
        Debug.Log("PlayerResetAnimated Reset");
        player.transform.position = resetPosition;
        player.Rigidbody.simulated = true;
        player.gameObject.SetActive(true);
        player.TransitionParticles.Play();
    }
}
