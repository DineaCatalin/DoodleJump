using UnityEngine;

[CreateAssetMenu(menuName = "Item/Behaviour/Rocket")]
public class RocketItemBehaviour : IItemBehaviour
{
    public override void OnPickUp(Player player, Item item)
    {
        player.ActivateRocket();
    }
}
