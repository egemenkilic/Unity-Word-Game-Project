using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript1 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "MAÇ";
    public string word1 = "ÇAM";
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
    public static float highScore1;
    public static int loadLevel;
    public GameObject pauseMenuUI;
    public int random;
    int x = 0, y = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 2;
        PlayerPrefs.SetInt("loadLevel",loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "A";
        bottom2Obj.GetComponent<TextMesh>().text = "Ç";
        bottom3Obj.GetComponent<TextMesh>().text = "M";
        highScore1 = PlayerPrefs.GetFloat("highScore1");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="M" && letter2.GetComponent<TextMesh>().text=="A" && letter3.GetComponent<TextMesh>().text=="Ç" &&
            letter11.GetComponent<TextMesh>().text == "Ç" && letter22.GetComponent<TextMesh>().text == "A" && letter33.GetComponent<TextMesh>().text == "M")
        {
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore1"))
            {
                PlayerPrefs.SetString("name1", menu.namee);
                PlayerPrefs.SetFloat("highScore1", score);
                highScore1 = PlayerPrefs.GetFloat("highScore1");
            }

        }
        
    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "M";
            selectletter[2] = "A";
            selectletter[3] = "Ç";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "Ç";
            selectletter[2] = "A";
            selectletter[3] = "M";
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
            bottom2Obj.GetComponent<TextMesh>().text = "Ç";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ç";
            bottom2Obj.GetComponent<TextMesh>().text = "M";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "M";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "Ç";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ç";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "M";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "Ç";
            bottom3Obj.GetComponent<TextMesh>().text = "M";
        }

    }
}