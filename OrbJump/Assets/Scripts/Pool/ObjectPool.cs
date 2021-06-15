using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private List<ObjectPoolElement> _elements;

    private Dictionary<InteractableType, List<GameObject>> _storage;

    private void Awake()
    {
        _storage = new Dictionary<InteractableType, List<GameObject>>();

        for (int i = 0; i < _elements.Count; i++)
        {
            var element = _elements[i];
            var prefabs = new List<GameObject>();

            for (int j = 0; j < element.Amount; j++)
            {
                var obj = InstantiateAndHide(element.Prefab);
                prefabs.Add(obj);
            }

            _storage.Add(element.Type, prefabs);
        }
    }

    public void HideAllObjects()
    {
        foreach (var itemType in _storage)
        {
            var active = itemType.Value.Where(item => item.activeSelf);
            if (active != null)
            {
                foreach (var obj in active)
                {
                    obj.SetActive(false);
                }
            }
        }
    }

    public GameObject GetObject(InteractableType objType)
    {
        var list = _storage[objType];

        var inactiveObject = list.FirstOrDefault(obj => !obj.activeSelf);

        if(inactiveObject == null)
        {
            inactiveObject = InstantiateAndHide(list[0]);
            list.Add(inactiveObject);
        }

        return inactiveObject;
    }

    private GameObject InstantiateAndHide(GameObject template)
    {
        var obj = Instantiate(template, transform);
        obj.SetActive(false);
        return obj;
    }
}