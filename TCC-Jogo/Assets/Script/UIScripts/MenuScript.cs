using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject ConfigPanel;   
    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Config()
    {
        ConfigPanel.SetActive(true);
    }
    public void ConfigBack()
    {
        ConfigPanel.SetActive(false);
    }
}
