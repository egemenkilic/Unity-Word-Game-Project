using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript6 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "KÖY";
    public string word1 = "YÜK";
    public string word2 = "ÖYKÜ";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter11;
    public Transform letter111;
    public Transform letter2;
    public Transform letter22;
    public Transform letter222;
    public Transform letter3;
    public Transform letter33;
    public Transform letter333;
    public Transform letter444;

    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore6;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 7;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "Ö";
        bottom2Obj.GetComponent<TextMesh>().text = "K";
        bottom3Obj.GetComponent<TextMesh>().text = "Y";
        bottom4Obj.GetComponent<TextMesh>().text = "Ü";

        highScore6 = PlayerPrefs.GetFloat("highScore6");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="K" && letter2.GetComponent<TextMesh>().text=="Ö" && letter3.GetComponent<TextMesh>().text=="Y" &&
            letter11.GetComponent<TextMesh>().text == "Y" && letter22.GetComponent<TextMesh>().text == "Ü" && letter33.GetComponent<TextMesh>().text == "K" &&
            letter111.GetComponent<TextMesh>().text == "Ö" && letter222.GetComponent<TextMesh>().text == "Y" && letter333.GetComponent<TextMesh>().text == "K"&&
            letter444.GetComponent<TextMesh>().text == "Ü")
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore6"))
            {
                PlayerPrefs.SetString("name6", menu.namee);
                PlayerPrefs.SetFloat("highScore6", score);
                highScore6 = PlayerPrefs.GetFloat("highScore6");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "K";
            selectletter[2] = "Ö";
            selectletter[3] = "Y";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "Y";
            selectletter[2] = "Ü";
            selectletter[3] = "K";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "Ö";
            selectletter[2] = "Y";
            selectletter[3] = "K";
            selectletter[4] = "Ü";
            letter111.GetComponent<TextMesh>().text = selectletter[1];
            letter222.GetComponent<TextMesh>().text = selectletter[2];
            letter333.GetComponent<TextMesh>().text = selectletter[3];
            letter444.GetComponent<TextMesh>().text = selectletter[4];
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

        if (z == 0)
        {
            if (currentWord == word2)
            {
                z = 1;
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
        selectletter[5] = "";
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
            bottom1Obj.GetComponent<TextMesh>().text = "Ö";
            bottom2Obj.GetComponent<TextMesh>().text = "Y";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
            bottom4Obj.GetComponent<TextMesh>().text = "Ü";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Y";
            bottom2Obj.GetComponent<TextMesh>().text = "Ü";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
            bottom4Obj.GetComponent<TextMesh>().text = "Ö";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "Ö";
            bottom3Obj.GetComponent<TextMesh>().text = "Y";
            bottom4Obj.GetComponent<TextMesh>().text = "Ü";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ö";
            bottom2Obj.GetComponent<TextMesh>().text = "K";
            bottom3Obj.GetComponent<TextMesh>().text = "Ü";
            bottom4Obj.GetComponent<TextMesh>().text = "Y";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Y";
            bottom2Obj.GetComponent<TextMesh>().text = "Ü";
            bottom3Obj.GetComponent<TextMesh>().text = "Ö";
            bottom4Obj.GetComponent<TextMesh>().text = "K";
        }

    }
}