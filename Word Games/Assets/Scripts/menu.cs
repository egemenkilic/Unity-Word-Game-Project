using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public InputField name;
    public static string namee;

    
    public void StartGame()
    {
        namee = name.text; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ScoreTable()
    {
        SceneManager.LoadScene("ScoreTable");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("loadLevel"));
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
