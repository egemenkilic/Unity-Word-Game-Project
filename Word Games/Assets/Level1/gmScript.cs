using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "TEL";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter2;
    public Transform letter3;
    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public static float score;
    public static float a=0;
    public static float highScore;
    public static int loadLevel;
    public GameObject pauseMenuUI;
    public int random;
    int x = 0;

    // Start is called before the first frame update
    void Start()
    {   
        score = 0;
        loadLevel = 1;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "T";
        bottom2Obj.GetComponent<TextMesh>().text = "E";
        bottom3Obj.GetComponent<TextMesh>().text = "L";
        highScore = PlayerPrefs.GetFloat("highScore");
        
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000 / (10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="T" && letter2.GetComponent<TextMesh>().text=="E" && letter3.GetComponent<TextMesh>().text=="L")
        {

            pauseMenuUI.SetActive(true);

            if (score>PlayerPrefs.GetFloat("highScore"))
            {
                PlayerPrefs.SetString("name", menu.namee);
                PlayerPrefs.SetFloat("highScore",score);
                highScore=PlayerPrefs.GetFloat("highScore");
            }

        }
    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "T";
            selectletter[2] = "E";
            selectletter[3] = "L";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];

        }

        if (x == 0)
        {
            if (currentWord == word)
            {
                x = 1;
                score += a;
                a = 0;
            }
        }
        else
            score -= 10;

        currentWord = "";
        selectletter[1] = "";
        selectletter[2] = "";
        selectletter[3] = "";
        selectletter[4] = "";
    }

    public void Left()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Right()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Switch()
    {
        random = Random.Range(0,4);
        if (random == 3)
        {
             bottom1Obj.GetComponent<TextMesh>().text = "E";
             bottom2Obj.GetComponent<TextMesh>().text = "T";
             bottom3Obj.GetComponent<TextMesh>().text = "L";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "L";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "T";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "T";
            bottom2Obj.GetComponent<TextMesh>().text = "L";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "T";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "L";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "L";
            bottom2Obj.GetComponent<TextMesh>().text = "T";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
        }

    }
}