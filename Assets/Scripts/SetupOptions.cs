using UnityEngine;
using UnityEngine.SceneManagement;
public class SetupOptions : MonoBehaviour
{
    public int playerCount;
    public int showPercentages;
    public int includeAchievements;
    public int joIVar;
    public int returnTripVar;
    public int gastroVar;
    public int prepVar;
    public string playerOneColor;
    public string playerTwoColor;
    public string playerThreeColor;
    public string playerFourColor;
    public string playerFiveColor;

    void Start()
    {
        // set defaults if no player prefs
        if (PlayerPrefs.HasKey("playerCount") == false)
        {
            PlayerPrefs.SetInt("playerCount", 3);
            PlayerPrefs.SetInt("showPercentages", 1);
            PlayerPrefs.SetInt("includeAchievements", 1);
            PlayerPrefs.SetInt("joIVar", 1);
            PlayerPrefs.SetInt("returnTripVar", 0);
            PlayerPrefs.SetInt("gastroVar", 0);
            PlayerPrefs.SetInt("prepVar", 0);
            PlayerPrefs.SetString("playerOneColor", "blue");
            PlayerPrefs.SetString("playerTwoColor", "purple");
            PlayerPrefs.SetString("playerThreeColor", "green");
            PlayerPrefs.SetString("playerFourColor", "yellow");
            PlayerPrefs.SetString("playerFiveColor", "gray");
        }
        
        // load player prefs
        playerCount = PlayerPrefs.GetInt("playerCount");
        showPercentages = PlayerPrefs.GetInt("showPercentages");
        includeAchievements = PlayerPrefs.GetInt("includeAchievements");
        joIVar = PlayerPrefs.GetInt("joIVar");
        returnTripVar = PlayerPrefs.GetInt("returnTripVar");
        gastroVar = PlayerPrefs.GetInt("gastroVar");
        prepVar = PlayerPrefs.GetInt("prepVar");
        playerOneColor = PlayerPrefs.GetString("playerOneColor");
        playerTwoColor = PlayerPrefs.GetString("playerTwoColor");
        playerThreeColor = PlayerPrefs.GetString("playerThreeColor");
        playerFourColor = PlayerPrefs.GetString("playerFourColor");
        playerFiveColor = PlayerPrefs.GetString("playerFiveColor");
    }

    public void LoadGameScreen()
    {
        SceneManager.LoadScene(2);
    }
}
