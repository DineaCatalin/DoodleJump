using UnityEngine;

[CreateAssetMenu(menuName = "Score")]
public class Score : ScriptableObject
{
    private const string HIGH_SCORE_KEY = "HighScore";

    public float CurrentScore;
    public float HighScore;
    public float PreviousHighscore;
    public bool  NewHighScore;

    public void LoadHighScore() => HighScore = PlayerPrefs.GetFloat(HIGH_SCORE_KEY, HighScore);
    public void SaveHighScore() => PlayerPrefs.SetFloat(HIGH_SCORE_KEY, HighScore);

    public void Reset()
    {
        CurrentScore = 0;
        NewHighScore = false;
    }

    public void SaveScore()
    {
        NewHighScore = false;
        PreviousHighscore = HighScore;
        if (HighScore < CurrentScore)
        {
            HighScore    = CurrentScore;
            NewHighScore = true;
        }
    }
}