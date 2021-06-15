﻿using UnityEngine;

[CreateAssetMenu(menuName = "Player/Death")]
public class PlayerAnimatedDeath : IPlayerDeath
{
    public override void Die(Player player) => player.DeathParticles.Play();
}
