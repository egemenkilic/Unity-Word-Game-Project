using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript5 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "YEN";
    public string word1 = "NEY";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter11;
    public Transform letter2;
    public Transform letter22;
    public Transform letter3;
    public Transform letter33;
    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public static float score=0;
    public static float a=0;
    public static float highScore5;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 6;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "Y";
        bottom2Obj.GetComponent<TextMesh>().text = "E";
        bottom3Obj.GetComponent<TextMesh>().text = "N";
        highScore5 = PlayerPrefs.GetFloat("highScore5");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="Y" && letter2.GetComponent<TextMesh>().text=="E" && letter3.GetComponent<TextMesh>().text=="N" &&
            letter11.GetComponent<TextMesh>().text == "N" && letter22.GetComponent<TextMesh>().text == "E" && letter33.GetComponent<TextMesh>().text == "Y")
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore5"))
            {
                PlayerPrefs.SetString("name5", menu.namee);
                PlayerPrefs.SetFloat("highScore5", score);
                highScore5 = PlayerPrefs.GetFloat("highScore5");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "Y";
            selectletter[2] = "E";
            selectletter[3] = "N";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "N";
            selectletter[2] = "E";
            selectletter[3] = "Y";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
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

        if (y == 0)
        {
            if (currentWord == word1)
            {
                y = 1;
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
        random = Random.Range(0, 4);
        if (random == 3)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Y";
            bottom2Obj.GetComponent<TextMesh>().text = "N";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "E";
            bottom2Obj.GetComponent<TextMesh>().text = "Y";
            bottom3Obj.GetComponent<TextMesh>().text = "N";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "E";
            bottom2Obj.GetComponent<TextMesh>().text = "N";
            bottom3Obj.GetComponent<TextMesh>().text = "Y";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "N";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "Y";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Y";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "N";
        }

    }
}