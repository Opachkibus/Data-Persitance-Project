using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text HighScoreText;


    void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        string highScoreName = PlayerPrefs.GetString("HighScoreName", "None");

        HighScoreText.text = $"High Score: {highScore}\nBy: {highScoreName}";

    }
    public void StartGame()
    {
        if (string.IsNullOrEmpty(nameInput.text))
        {
            Debug.Log("Player name is empty");
            return;
        }

        PlayerPrefs.SetString("PlayerName", nameInput.text);
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Only shows in editor
    }
}
