using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreScript : MonoBehaviour {
    public static int highScore=0;
    public Text highText;
    // Use this for initialization
    void Start () {
        highScore = PlayerPrefs.GetInt("highScore");
	}
	
	// Update is called once per frame
	void Update () {
        highText.text =highScore.ToString();
        if (highScore < PlayerCube.score)
        {
           highScore = PlayerCube.score;
            PlayerPrefs.SetInt("highScore",highScore);
        }
        highText.text = highScore.ToString();
    }
}
