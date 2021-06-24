using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetupOptions : MonoBehaviour
{
    public Dropdown numberOfPlayersDrop;
    public int playerCount;
    public Dropdown showPercentagesDrop;
    public int showPercentages;
    public Dropdown includeAchievementsDrop;
    public int includeAchievements;
    public Toggle joIToggle;
    public int joIVar;
    public Toggle returnTripToggle;
    public int returnTripVar;
    public Toggle gastroToggle;
    public int gastroVar;
    public Toggle prepToggle;
    public int prepVar;
    public Dropdown playerOneColorDrop;
    public string playerOneColor;
    public Dropdown playerTwoColorDrop;
    public string playerTwoColor;
    public Dropdown playerThreeColorDrop;
    public string playerThreeColor;
    public Dropdown playerFourColorDrop;
    public string playerFourColor;
    public Dropdown playerFiveColorDrop;
    public string playerFiveColor;

    void Start()
    {
        // set defaults if no player prefs
        if (PlayerPrefs.HasKey("playerCount") == false)
        {
            numberOfPlayersDrop.value = 3;
            showPercentagesDrop.value = 1;
            includeAchievementsDrop.value = 1;
            joIToggle.isOn = true;
            returnTripToggle.isOn = false;
            gastroToggle.isOn = false;
            prepToggle.isOn = true;
            playerOneColorDrop.value = 0;
            playerTwoColorDrop.value = 1;
            playerThreeColorDrop.value = 2;
            playerFourColorDrop.value = 3;
            playerFiveColorDrop.value = 4;
        }
        
        // load player prefs
        numberOfPlayersDrop.value = (PlayerPrefs.GetInt("playerCount") - 2);
        showPercentagesDrop.value = PlayerPrefs.GetInt("showPercentages");
        includeAchievementsDrop.value = PlayerPrefs.GetInt("includeAchievements");
        if (PlayerPrefs.GetInt("joIVar") == 1)
        {
            joIToggle.isOn = true;
        }
        else
        {
            joIToggle.isOn = false;
        }
        if (PlayerPrefs.GetInt("returnTripVar") == 1)
        {
            returnTripToggle.isOn = true;
        }
        else
        {
            returnTripToggle.isOn = false;
        }if (PlayerPrefs.GetInt("gastroVar") == 1)
        {
            gastroToggle.isOn = true;
        }
        else
        {
            gastroToggle.isOn = false;
        }if (PlayerPrefs.GetInt("prepVar") == 1)
        {
            prepToggle.isOn = true;
        }
        else
        {
            prepToggle.isOn = false;
        }
        playerOneColor = PlayerPrefs.GetString("playerOneColor");
        playerTwoColor = PlayerPrefs.GetString("playerTwoColor");
        playerThreeColor = PlayerPrefs.GetString("playerThreeColor");
        playerFourColor = PlayerPrefs.GetString("playerFourColor");
        playerFiveColor = PlayerPrefs.GetString("playerFiveColor");
    }

    void Update()
    {
        switch (numberOfPlayersDrop.value)
        {
            case 0:
                playerCount = 2;
                PlayerPrefs.SetInt("playerCount", 2);
                break;
            case 1:
                playerCount = 3;
                PlayerPrefs.SetInt("playerCount", 3);
                break;
            case 2:
                playerCount = 4;
                PlayerPrefs.SetInt("playerCount", 4);
                break;
            case 3:
                playerCount = 5;
                PlayerPrefs.SetInt("playerCount", 5);
                break;
        }
        switch (showPercentagesDrop.value)
        {
            case 0:
                PlayerPrefs.SetInt("showPercentages", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("showPercentages", 1);
                break;
        }
        switch (includeAchievementsDrop.value)
        {
            case 0:
                PlayerPrefs.SetInt("includeAchievements", 0);
                break;
            case 1:
                PlayerPrefs.SetInt("includeAchievements", 1);
                break;
        }
        if (joIToggle.isOn)
        {
            PlayerPrefs.SetInt("joIVar", 1);
        }
        else
        {
            PlayerPrefs.SetInt("joIVar", 0);
        }
        if (returnTripToggle.isOn)
        {
            PlayerPrefs.SetInt("returnTripVar", 1);
        }
        else
        {
            PlayerPrefs.SetInt("returnTripVar", 0);
        }
        if (gastroToggle.isOn)
        {
            PlayerPrefs.SetInt("gastroVar", 1);
        }
        else
        {
            PlayerPrefs.SetInt("gastroVar", 0);
        }
        if (prepToggle.isOn)
        {
            PlayerPrefs.SetInt("prepVar", 1);
        }
        else
        {
            PlayerPrefs.SetInt("prepVar", 0);
        }
    }

    public void LoadGameScreen()
    {
        SceneManager.LoadScene(2);
    }
}
