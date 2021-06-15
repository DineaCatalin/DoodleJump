using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Level/LevelChunk")]
public class LevelChunkData : ScriptableObject
{
    public List<LevelElementData> Data = new List<LevelElementData>();
    public float                  ChunkMiddleYPosition;
    public float                  ChunkTopYPosition;
    public float                  ChunkBottomYPosition;
}