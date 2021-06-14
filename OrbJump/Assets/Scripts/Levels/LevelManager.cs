using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ObjectPool           _pool;
    [SerializeField] private List<LevelChunkData> _levelChunks;
    [SerializeField] private Transform            _showNewChunkTrigger;
    [SerializeField] private float                _offsetBetweenLevelChunks;

    private float _originY;

    private void Start()
    {
        _showNewChunkTrigger.position = Vector2.zero;
        ShowLevelChunk(_levelChunks[0]);
    }

    public void ShowNextChunk()
    {
        var nextChunkIndex = Random.Range(0, _levelChunks.Count);
        Debug.Log($"ShowNextChunk {nextChunkIndex}");
        ShowLevelChunk(_levelChunks[nextChunkIndex]);
    }

    private void ShowLevelChunk(LevelChunkData levelChunk)
    {
        Debug.Log("ShowLevelChunk");
        _showNewChunkTrigger.position = new Vector2(_showNewChunkTrigger.position.x, 
            levelChunk.ChunkMiddleYPosition + _originY);

        for (int i = 0; i < levelChunk.Data.Count; i++)
        {
            var type = levelChunk.Data[i].Type;
            var positions = levelChunk.Data[i].Positions;

            for (int j = 0; j < positions.Count; j++)
            {
                var levelElement = _pool.GetObject(type);
                levelElement.transform.position = new Vector2(positions[j].x, positions[j].y + _originY + _offsetBetweenLevelChunks);
                levelElement.SetActive(true);
            }
        }

        _originY += levelChunk.ChunkTopYPosition;
    }
}