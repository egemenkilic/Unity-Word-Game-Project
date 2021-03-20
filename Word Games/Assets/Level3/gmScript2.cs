using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript2 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "SİM";
    public string word1 = "MİS";
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
    public static float highScore2;
    public static int loadLevel;
    public GameObject pauseMenuUI;
    public int random;
    int x=0 , y=0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 3;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "S";
        bottom2Obj.GetComponent<TextMesh>().text = "M";
        bottom3Obj.GetComponent<TextMesh>().text = "İ";
        highScore2 = PlayerPrefs.GetFloat("highScore2");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="S" && letter2.GetComponent<TextMesh>().text=="İ" && letter3.GetComponent<TextMesh>().text=="M" &&
            letter11.GetComponent<TextMesh>().text == "M" && letter22.GetComponent<TextMesh>().text == "İ" && letter33.GetComponent<TextMesh>().text == "S")
        {
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore2"))
            {
                PlayerPrefs.SetString("name2", menu.namee);
                PlayerPrefs.SetFloat("highScore2", score);
                highScore2 = PlayerPrefs.GetFloat("highScore2");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "S";
            selectletter[2] = "İ";
            selectletter[3] = "M";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "M";
            selectletter[2] = "İ";
            selectletter[3] = "S";
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
            bottom1Obj.GetComponent<TextMesh>().text = "M";
            bottom2Obj.GetComponent<TextMesh>().text = "S";
            bottom3Obj.GetComponent<TextMesh>().text = "İ";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "İ";
            bottom2Obj.GetComponent<TextMesh>().text = "S";
            bottom3Obj.GetComponent<TextMesh>().text = "M";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "M";
            bottom2Obj.GetComponent<TextMesh>().text = "İ";
            bottom3Obj.GetComponent<TextMesh>().text = "S";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "S";
            bottom2Obj.GetComponent<TextMesh>().text = "İ";
            bottom3Obj.GetComponent<TextMesh>().text = "M";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "S";
            bottom2Obj.GetComponent<TextMesh>().text = "M";
            bottom3Obj.GetComponent<TextMesh>().text = "İ";
        }

    }
}