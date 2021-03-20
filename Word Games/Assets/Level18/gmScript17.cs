using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript17 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "KAS";
    public string word1 = "AKIL";
    public string word2 = "ISLAK";
    public string word3 = "SAKLI";
    public string word4 = "KISA";
    public string word5 = "AK";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" , "", "", "", ""};
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter2;
    public Transform letter3;
    public Transform letter4;
    public Transform letter5;
    public Transform letter6;
    public Transform letter7;
    public Transform letter8;
    public Transform letter9;
    public Transform letter10;
    public Transform letter11;
    public Transform letter12;
    public Transform letter13;
    public Transform letter14;
    public Transform letter15;
    public Transform letter16;
    public Transform letter17;
    public Transform letter18;
    public Transform letter19;
    public Transform letter20;
    public Transform letter21;
    public Transform letter22;
    public Transform letter23;
   

    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;
    public Transform bottom5Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore15;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0, p = 0, k = 0,v=0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 16;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "A";
        bottom2Obj.GetComponent<TextMesh>().text = "K";
        bottom3Obj.GetComponent<TextMesh>().text = "S";
        bottom4Obj.GetComponent<TextMesh>().text = "L";
        bottom5Obj.GetComponent<TextMesh>().text = "I";

        highScore15 = PlayerPrefs.GetFloat("highScore15");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="K" && letter2.GetComponent<TextMesh>().text=="A" && letter3.GetComponent<TextMesh>().text=="S" &&
            letter4.GetComponent<TextMesh>().text == "A" && letter5.GetComponent<TextMesh>().text == "K" && letter6.GetComponent<TextMesh>().text == "I" &&
            letter7.GetComponent<TextMesh>().text == "L" && letter8.GetComponent<TextMesh>().text == "I" && letter9.GetComponent<TextMesh>().text == "S"&&
            letter10.GetComponent<TextMesh>().text == "L" && letter11.GetComponent<TextMesh>().text == "A" && letter12.GetComponent<TextMesh>().text == "K" &&
            letter13.GetComponent<TextMesh>().text == "S" && letter14.GetComponent<TextMesh>().text == "A" && letter15.GetComponent<TextMesh>().text == "K" &&
            letter16.GetComponent<TextMesh>().text == "L" && letter17.GetComponent<TextMesh>().text == "I" &&letter18.GetComponent<TextMesh>().text == "K" &&
            letter19.GetComponent<TextMesh>().text == "I" && letter20.GetComponent<TextMesh>().text == "S" && letter21.GetComponent<TextMesh>().text == "A" && 
            letter22.GetComponent<TextMesh>().text == "A" && letter23.GetComponent<TextMesh>().text == "K"

            )
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore15"))
            {
                PlayerPrefs.SetString("name15", menu.namee);
                PlayerPrefs.SetFloat("highScore15", score);
                highScore15 = PlayerPrefs.GetFloat("highScore15");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "K";
            selectletter[2] = "A";
            selectletter[3] = "S";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "A";
            selectletter[2] = "K";
            selectletter[3] = "I";
            selectletter[4] = "L";
            letter4.GetComponent<TextMesh>().text = selectletter[1];
            letter5.GetComponent<TextMesh>().text = selectletter[2];
            letter6.GetComponent<TextMesh>().text = selectletter[3];
            letter7.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "I";
            selectletter[2] = "S";
            selectletter[3] = "L";
            selectletter[4] = "A";
            selectletter[5] = "K";
            letter8.GetComponent<TextMesh>().text = selectletter[1];
            letter9.GetComponent<TextMesh>().text = selectletter[2];
            letter10.GetComponent<TextMesh>().text = selectletter[3];
            letter11.GetComponent<TextMesh>().text = selectletter[4];
            letter12.GetComponent<TextMesh>().text = selectletter[5];
        }

        if (currentWord == word3)
        {
            selectletter[1] = "S";
            selectletter[2] = "A";
            selectletter[3] = "K";
            selectletter[4] = "L";
            selectletter[5] = "I";
            letter13.GetComponent<TextMesh>().text = selectletter[1];
            letter14.GetComponent<TextMesh>().text = selectletter[2];
            letter15.GetComponent<TextMesh>().text = selectletter[3];
            letter16.GetComponent<TextMesh>().text = selectletter[4];
            letter17.GetComponent<TextMesh>().text = selectletter[5];
        }

        if (currentWord == word4)
        {
            selectletter[1] = "K";
            selectletter[2] = "I";
            selectletter[3] = "S";
            selectletter[4] = "A";
            
            letter18.GetComponent<TextMesh>().text = selectletter[1];
            letter19.GetComponent<TextMesh>().text = selectletter[2];
            letter20.GetComponent<TextMesh>().text = selectletter[3];
            letter21.GetComponent<TextMesh>().text = selectletter[4];
            
        }
        if (currentWord == word5)
        {
            selectletter[1] = "A";
            selectletter[2] = "K";


            letter22.GetComponent<TextMesh>().text = selectletter[1];
            letter23.GetComponent<TextMesh>().text = selectletter[2];

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

        if (k == 0)
        {
            if (currentWord == word4)
            {
                k = 1;
                score += a;
                a = 0;
            }
        }

        if (v == 0)
        {
            if (currentWord == word5)
            {
                v = 1;
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
        selectletter[7] = "";
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
            bottom1Obj.GetComponent<TextMesh>().text = "S";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
            bottom4Obj.GetComponent<TextMesh>().text = "L";
            bottom5Obj.GetComponent<TextMesh>().text = "I";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "I";
            bottom2Obj.GetComponent<TextMesh>().text = "S";
            bottom3Obj.GetComponent<TextMesh>().text = "L";
            bottom4Obj.GetComponent<TextMesh>().text = "A";
            bottom5Obj.GetComponent<TextMesh>().text = "K";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "S";
            bottom4Obj.GetComponent<TextMesh>().text = "L";
            bottom5Obj.GetComponent<TextMesh>().text = "I";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "L";
            bottom4Obj.GetComponent<TextMesh>().text = "S";
            bottom5Obj.GetComponent<TextMesh>().text = "I";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "I";
            bottom2Obj.GetComponent<TextMesh>().text = "S";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
            bottom4Obj.GetComponent<TextMesh>().text = "L";
            bottom5Obj.GetComponent<TextMesh>().text = "A";
        }

    }
}