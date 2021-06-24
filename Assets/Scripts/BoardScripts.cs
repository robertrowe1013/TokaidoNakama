using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScripts : MonoBehaviour
{
    GameObject[] fourPlayerPaths;
    GameObject[] fivePlayerPaths; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Count: " + PlayerPrefs.GetInt("playerCount"));
        if (PlayerPrefs.GetInt("playerCount") == 4)
        {
            fivePlayerPaths = GameObject.FindGameObjectsWithTag("FivePlayer");
            foreach (GameObject path in fivePlayerPaths)
            {
                path.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("playerCount") < 4)
        {
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
