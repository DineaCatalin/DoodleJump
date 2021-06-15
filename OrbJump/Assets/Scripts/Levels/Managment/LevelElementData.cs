using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelElementData
{
    public InteractableType Type;
    public List<Vector2> Positions;

    public LevelElementData(InteractableType type)
    {
        Type = type;
        Positions = new List<Vector2>();
    }
}
