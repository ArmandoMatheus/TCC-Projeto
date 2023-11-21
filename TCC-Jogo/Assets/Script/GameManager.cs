using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int placedUnits;
    public static int enemiesKilled;
    public static int damageRecieved;
    public static int trashScore;
    public TMP_Text scoreNumberText;
    public TMP_Text scoreText;

    public GameObject gameOverPanel;
    public GameObject winPanel;
    public GameObject losePanel;
    void Start()
    {
        
    }
    public void SetScore()
    {
        scoreNumberText.text = enemiesKilled.ToString();        
    }
    public void GameOver()
    {
        TrashManager.plasticoN = 5;
        TrashManager.vidroN = 5;
        TrashManager.papelN = 5;
        TrashManager.metalN = 5;
        gameOverPanel.SetActive(true);
    }

    public void GameLose()
    {
        GameOver();
        SetScore();
        scoreText.color = new Color32(255, 0, 0, 255);
        scoreNumberText.color = new Color32(255, 0, 0, 255);
        losePanel.SetActive(true);
    }
    public void GameWin()
    {
        GameOver();
        SetScore();
        scoreText.color = new Color32(0, 255, 0, 255);
        scoreNumberText.color = new Color32(0, 255, 0, 255);
        winPanel.SetActive(true);
    }
}
