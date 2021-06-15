using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Behaviour/Spring")]
public class SpringItemBehaviour : IItemBehaviour
{
    public float JumpPower;

    public override void OnPickUp(Player player, Item item)
    {
        player.Jump(JumpPower);
        item.PlayInteractionParticles();
    }
}
