using UnityEngine;
using UnityEditor;

public class LevelGeneratorWindow : EditorWindow
{
    [MenuItem("Window/Level Generator")]
    public static void ShowWindow()
    {
        GetWindow<LevelGeneratorWindow>("Level Generator");
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Save Level Chunk in Root"))
        {
            SaveLevelChunk();
        }
    }

    private void SaveLevelChunk()
    {
        var levelGeneratorGO = GameObject.Find("LevelGenerator").GetComponent<LevelGenerator>();

        if(levelGeneratorGO != null)
        {
            var levelGenerator = levelGeneratorGO.GetComponent<LevelGenerator>();
            levelGenerator.SaveChunkData();
            Debug.Log("Saving Level Chunk");
        }
        else
        {
            Debug.LogError("No LevelGenerator found in current Scene. Try going to BuildLevel Scene");
        }
        
    }
}