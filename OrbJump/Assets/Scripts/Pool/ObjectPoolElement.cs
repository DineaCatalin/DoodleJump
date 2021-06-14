using UnityEngine;

[CreateAssetMenu(menuName = "ObjectPool/Element")]
public class ObjectPoolElement : ScriptableObject
{
    public InteractableType Type;
    public int              Amount;
    public GameObject       Prefab;
}
