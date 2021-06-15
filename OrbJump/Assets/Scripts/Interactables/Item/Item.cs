using UnityEngine;

public class Item : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] private IItemBehaviour _item;
    [SerializeField] private ParticleSystem _onIteractionParticles;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(PLAYER_TAG))
        {
            var player = collision.gameObject.GetComponent<Player>();
            _item.OnPickUp(player, this);
            
            if(_item.HideOnInteraction)
            {
                Hide();
            }
        }
    }

    public void Hide() => gameObject.SetActive(false);
  
    public void PlayInteractionParticles()
    {
        if(_onIteractionParticles != null)
        {
            _onIteractionParticles.Play();
        }
    }
}
