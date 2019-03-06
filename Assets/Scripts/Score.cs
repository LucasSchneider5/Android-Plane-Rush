using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Transform Charakter;
    public Text scoreText;
    public Text HighscoreText;

    private int score;
    private int HighScore;

    public void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        HighscoreText.text = HighScore.ToString();
        Debug.Log(HighScore);
        /*HighscoreText.text = PlayerPrefs.GetString("HighScore");
        PlayerPrefs.Save();*/
    }

    private void Update()
    {
        score = Mathf.FloorToInt(Charakter.position.x);
        scoreText.text = score.ToString();

        if (score > HighScore)
        {
            HighScore = score;
            HighscoreText.text = HighScore.ToString();
            PlayerPrefs.SetInt("HighScore", HighScore);
            PlayerPrefs.Save();
        }
        /*scoreText.text = Charakter.position.x.ToString("0");

        int number = int.Parse(scoreText.text);
        int highscore = int.Parse(PlayerPrefs.GetString("HighScore"));

        if (number > highscore)
        {
            PlayerPrefs.SetString("HighScore", scoreText.text);
            PlayerPrefs.Save();
        }*/
    }
}
