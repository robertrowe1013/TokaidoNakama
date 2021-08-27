using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoardScripts : MonoBehaviour
{
    GameObject[] fourPlayerPaths;
    GameObject[] fivePlayerPaths; 
    public int currentPlayer;
    enum playerColors
    {
        blue, purple, green, yellow, gray
    }
    void Start()
    {
        Debug.Log("Player Count: " + PlayerPrefs.GetInt("playerCount"));
        if (PlayerPrefs.GetInt("playerCount") == 5)
        {
            // activate fourth and fifth player meeples
            GameObject fifthPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line5/Meeple");
            Image fifthImage = fifthPlayerMeeple.GetComponent<Image>();
            Color fifthColor = fifthImage.color;
            GameObject fourthPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line4/Meeple");
            Image fourthImage = fourthPlayerMeeple.GetComponent<Image>();
            fourthImage.color = Color.blue;
            fifthImage.color = Color.gray;
        }
        if (PlayerPrefs.GetInt("playerCount") == 4)
        {
            // remove fifth player inn paths
            fivePlayerPaths = GameObject.FindGameObjectsWithTag("FivePlayer");
            foreach (GameObject path in fivePlayerPaths)
            {
                path.SetActive(false);
            }
            // active fourth player meeple
            GameObject fourthPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line4/Meeple");
            Image fourthImage = fourthPlayerMeeple.GetComponent<Image>();
            Color fourthColor = Color.blue;
            fourthImage.color = fourthColor;
        }
        if (PlayerPrefs.GetInt("playerCount") < 4)
        {
            // remove 4th and 5th player in paths and second spaces on travel paths
            fivePlayerPaths = GameObject.FindGameObjectsWithTag("FivePlayer");
            foreach (GameObject path in fivePlayerPaths)
            {
                path.SetActive(false);
            }
            fourPlayerPaths = GameObject.FindGameObjectsWithTag("FourPlayer");
            foreach (GameObject path in fourPlayerPaths)
            {
                path.SetActive(false);
            }
        }
        GameObject thirdPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line3/Meeple");
        Image thirdImage = thirdPlayerMeeple.GetComponent<Image>();
        GameObject secondPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line2/Meeple");
        Image secondImage = secondPlayerMeeple.GetComponent<Image>();
        GameObject firstPlayerMeeple = GameObject.Find("BoardCanvas/Board1Layout/Inn1Board1/Line1/Meeple");
        Image firstImage = firstPlayerMeeple.GetComponent<Image>();
        Color newColor = thirdImage.color;
        newColor.a = 1;
        thirdImage.color = newColor;
        secondImage.color = newColor;
        firstImage.color = newColor;
        // activae 1st, 2nd, and 3rd player meeples

        currentPlayer = PlayerPrefs.GetInt("playerOneColor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
