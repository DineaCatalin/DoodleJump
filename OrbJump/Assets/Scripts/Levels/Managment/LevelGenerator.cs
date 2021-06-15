using UnityEngine;
using System.Linq;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform      _root;
    [SerializeField] private LevelChunkData _chunkData;

    public void SaveChunkData()
    {
        var list = _chunkData.Data;
        list.Clear();

        foreach (Transform child in _root)
        {
            var type = child.GetComponent<LevelElement>().Type;
            var levelElemData = list.FirstOrDefault(x => x.Type == type);

            if(levelElemData == null)
            {
                levelElemData = new LevelElementData(type);
                list.Add(levelElemData);
            }

            levelElemData.Positions.Add(child.position);
            SetBoundries(child.position.y);
        }

        _chunkData.ChunkMiddleYPosition = (_chunkData.ChunkTopYPosition + _chunkData.ChunkBottomYPosition) / 2f;

        ForceSerialization(_chunkData);
    }

    void ForceSerialization(LevelChunkData data)
    {
#if UNITY_EDITOR
        UnityEditor.EditorUtility.SetDirty(data);
#endif
    }

    private void SetBoundries(float yPos)
    {
        if (yPos > _chunkData.ChunkTopYPosition)
            _chunkData.ChunkTopYPosition = yPos;
        if (yPos < _chunkData.ChunkBottomYPosition)
            _chunkData.ChunkBottomYPosition = yPos;
    }
}
