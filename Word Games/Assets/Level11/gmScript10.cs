using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript10 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "ALEV";
    public string word1 = "VALE";
    public string word2 = "EVLA"; 
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
    public Transform letter4;
    public Transform letter44;
    public Transform letter444;

    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore10;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 11;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "A";
        bottom2Obj.GetComponent<TextMesh>().text = "L";
        bottom3Obj.GetComponent<TextMesh>().text = "E";
        bottom4Obj.GetComponent<TextMesh>().text = "V";

        highScore10 = PlayerPrefs.GetFloat("highScore10");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="A" && letter2.GetComponent<TextMesh>().text=="L" && letter3.GetComponent<TextMesh>().text=="E" && letter4.GetComponent<TextMesh>().text == "V" &&
            letter11.GetComponent<TextMesh>().text == "V" && letter22.GetComponent<TextMesh>().text == "A" && letter33.GetComponent<TextMesh>().text == "L" && letter44.GetComponent<TextMesh>().text == "E" &&
            letter111.GetComponent<TextMesh>().text == "E" && letter222.GetComponent<TextMesh>().text == "V" && letter333.GetComponent<TextMesh>().text == "L"&&
            letter444.GetComponent<TextMesh>().text == "A")
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore10"))
            {
                PlayerPrefs.SetString("name10", menu.namee);
                PlayerPrefs.SetFloat("highScore10", score);
                highScore10 = PlayerPrefs.GetFloat("highScore10");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "A";
            selectletter[2] = "L";
            selectletter[3] = "E";
            selectletter[4] = "V";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
            letter4.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "V";
            selectletter[2] = "A";
            selectletter[3] = "L";
            selectletter[4] = "E";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
            letter44.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "E";
            selectletter[2] = "V";
            selectletter[3] = "L";
            selectletter[4] = "A";
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
        selectletter[6] = "";
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
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "L";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
            bottom4Obj.GetComponent<TextMesh>().text = "V";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "L";
            bottom2Obj.GetComponent<TextMesh>().text = "V";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
            bottom4Obj.GetComponent<TextMesh>().text = "A";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "E";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "L";
            bottom4Obj.GetComponent<TextMesh>().text = "V";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "V";
            bottom4Obj.GetComponent<TextMesh>().text = "L";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "V";
            bottom2Obj.GetComponent<TextMesh>().text = "L";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
            bottom4Obj.GetComponent<TextMesh>().text = "E";
        }

    }
}