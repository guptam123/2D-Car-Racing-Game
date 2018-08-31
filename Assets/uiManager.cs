using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public Button[] buttons;
    public Text scoreText;
    bool gameover;
    int score;

	// Use this for initialization
	void Start () {
        gameover = false;
        score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE: " + score;
	}

    void scoreUpdate()
    {
        if (!gameover)
        {
            score += 1;
        }
    }
    public void gameOver()
    {
        gameover = true;
        foreach(Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }

    }
    public void Play()
    {
        Application.LoadLevel("Level1");
    }
    public void Pause()
    {
        if (Time.timeScale == 1)
        { Time.timeScale = 0; }
        else if (Time.timeScale == 0)
        { Time.timeScale = 1; }
    }


public void Menu()
{
    Application.LoadLevel("menuScene");
}
public void Exit()
{
    Application.Quit();
}
}

