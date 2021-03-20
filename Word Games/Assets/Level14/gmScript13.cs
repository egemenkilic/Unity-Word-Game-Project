using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript13 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "HAP";
    public string word1 = "HAT";
    public string word2 = "PATİ";
    public string word3 = "HATİP";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" , "", "", ""};
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter11;
    public Transform letter111;
    public Transform letter1111;
    public Transform letter2;
    public Transform letter22;
    public Transform letter222;
    public Transform letter2222;
    public Transform letter3;
    public Transform letter33;
    public Transform letter333;
    public Transform letter3333;
    public Transform letter444;
    public Transform letter4444;
    public Transform letter5555;

    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;
    public Transform bottom5Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore13;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0, p = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 14;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "H";
        bottom2Obj.GetComponent<TextMesh>().text = "A";
        bottom3Obj.GetComponent<TextMesh>().text = "T";
        bottom4Obj.GetComponent<TextMesh>().text = "İ";
        bottom5Obj.GetComponent<TextMesh>().text = "P";

        highScore13 = PlayerPrefs.GetFloat("highScore13");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="H" && letter2.GetComponent<TextMesh>().text=="A" && letter3.GetComponent<TextMesh>().text=="P" &&
            letter11.GetComponent<TextMesh>().text == "H" && letter22.GetComponent<TextMesh>().text == "A" && letter33.GetComponent<TextMesh>().text == "T" &&
            letter111.GetComponent<TextMesh>().text == "P" && letter222.GetComponent<TextMesh>().text == "A" && letter333.GetComponent<TextMesh>().text == "T"&&
            letter444.GetComponent<TextMesh>().text == "İ" &&
            letter1111.GetComponent<TextMesh>().text == "H" && letter2222.GetComponent<TextMesh>().text == "A" && letter3333.GetComponent<TextMesh>().text == "T" &&
            letter4444.GetComponent<TextMesh>().text == "İ" && letter5555.GetComponent<TextMesh>().text == "P")
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore13"))
            {
                PlayerPrefs.SetString("name13", menu.namee);
                PlayerPrefs.SetFloat("highScore13", score);
                highScore13 = PlayerPrefs.GetFloat("highScore13");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "H";
            selectletter[2] = "A";
            selectletter[3] = "P";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "H";
            selectletter[2] = "A";
            selectletter[3] = "T";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "P";
            selectletter[2] = "A";
            selectletter[3] = "T";
            selectletter[4] = "İ";
            letter111.GetComponent<TextMesh>().text = selectletter[1];
            letter222.GetComponent<TextMesh>().text = selectletter[2];
            letter333.GetComponent<TextMesh>().text = selectletter[3];
            letter444.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word3)
        {
            selectletter[1] = "H";
            selectletter[2] = "A";
            selectletter[3] = "T";
            selectletter[4] = "İ";
            selectletter[5] = "P";
            letter1111.GetComponent<TextMesh>().text = selectletter[1];
            letter2222.GetComponent<TextMesh>().text = selectletter[2];
            letter3333.GetComponent<TextMesh>().text = selectletter[3];
            letter4444.GetComponent<TextMesh>().text = selectletter[4];
            letter5555.GetComponent<TextMesh>().text = selectletter[5];
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

        if (p == 0)
        {
            if (currentWord == word3)
            {
                p = 1;
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
            bottom1Obj.GetComponent<TextMesh>().text = "H";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "T";
            bottom4Obj.GetComponent<TextMesh>().text = "İ";
            bottom5Obj.GetComponent<TextMesh>().text = "P";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "P";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "T";
            bottom4Obj.GetComponent<TextMesh>().text = "İ";
            bottom5Obj.GetComponent<TextMesh>().text = "H";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "P";
            bottom3Obj.GetComponent<TextMesh>().text = "İ";
            bottom4Obj.GetComponent<TextMesh>().text = "H";
            bottom5Obj.GetComponent<TextMesh>().text = "T";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "İ";
            bottom2Obj.GetComponent<TextMesh>().text = "H";
            bottom3Obj.GetComponent<TextMesh>().text = "T";
            bottom4Obj.GetComponent<TextMesh>().text = "A";
            bottom5Obj.GetComponent<TextMesh>().text = "P";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "T";
            bottom2Obj.GetComponent<TextMesh>().text = "P";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
            bottom4Obj.GetComponent<TextMesh>().text = "İ";
            bottom5Obj.GetComponent<TextMesh>().text = "H";
        }

    }
}