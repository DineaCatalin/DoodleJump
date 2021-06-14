using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private IItemBehaviour _item;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(PLAYER_TAG))
        {
            var player = collision.gameObject.GetComponent<Player>();
            _item.OnPickUp(player, this);
            Hide();
        }
    }

    public void Hide()
    {
        // Add to pull later
        // For now just deactivate
        gameObject.SetActive(false);
    }
}
