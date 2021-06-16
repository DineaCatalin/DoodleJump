using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private ObjectPool           _pool;
    [SerializeField] private LevelChunkData       _startChunk;
    [SerializeField] private List<LevelChunkData> _levelChunks;
    [SerializeField] private Transform            _showNewChunkTrigger;
    [SerializeField] private float                _offsetBetweenLevelChunks;

    private float _originY;

    //private void Start() => ShowInitialChunk();

    public void ShowNextChunk()
    {
        Debug.Log("LevelManager ShowNextChunk");

        var nextChunkIndex = Random.Range(0, _levelChunks.Count);
        ShowLevelChunk(_levelChunks[nextChunkIndex]);
    }

    public void ResetLevel()
    {
        Debug.Log("LevelManager ResetLevel");
        _pool.HideAllObjects();
        ShowInitialChunk();
    }

    private void ShowInitialChunk()
    {
        Debug.Log("LevelManager ShowInitialChunk");
        _originY = 0;
        ShowLevelChunk(_startChunk);
        _showNewChunkTrigger.position = Vector2.zero;
    }

    private void ShowLevelChunk(LevelChunkData levelChunk)
    {
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