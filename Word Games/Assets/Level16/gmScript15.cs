using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript15 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "KAT";
    public string word1 = "KITA";
    public string word2 = "BEKA";
    public string word3 = "BATKI";
    public string word4 = "BATIK";
    public string word5 = "AKIBET";


    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" , "", "", ""};
    public static int letterNum = 0;
    public Transform letter1; //K
    public Transform letter2; //A
    public Transform letter3; //T

    public Transform letter11; //K
    public Transform letter22; //I
    public Transform letter33; //T
    public Transform letter44; //A

    public Transform letter111; //B
    public Transform letter222; //E
    public Transform letter333; //K
    public Transform letter444; //A
    
    public Transform letter1111; //B
    public Transform letter2222; //A
    public Transform letter3333; //T
    public Transform letter4444; //K
    public Transform letter5555; //I

    public Transform letter11111; //B
    public Transform letter22222; //A
    public Transform letter33333; //T
    public Transform letter44444; //I
    public Transform letter55555; //K

    public Transform letter111111; //A
    public Transform letter222222; //K
    public Transform letter333333; //I
    public Transform letter444444; //B
    public Transform letter555555; //E
    public Transform letter666666; //T


    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;
    public Transform bottom5Obj;
    public Transform bottom6Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore16;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0, p = 0, q=0, r=0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 17;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "A";
        bottom2Obj.GetComponent<TextMesh>().text = "K";
        bottom3Obj.GetComponent<TextMesh>().text = "I";
        bottom4Obj.GetComponent<TextMesh>().text = "B";
        bottom5Obj.GetComponent<TextMesh>().text = "E";
        bottom6Obj.GetComponent<TextMesh>().text = "T";

        highScore16 = PlayerPrefs.GetFloat("highScore16");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="K" && letter2.GetComponent<TextMesh>().text=="A" && letter3.GetComponent<TextMesh>().text=="T" &&
            letter11.GetComponent<TextMesh>().text == "K" && letter22.GetComponent<TextMesh>().text == "I" && letter33.GetComponent<TextMesh>().text == "T" && letter44.GetComponent<TextMesh>().text == "A" &&
            letter111.GetComponent<TextMesh>().text == "B" && letter222.GetComponent<TextMesh>().text == "E" && letter333.GetComponent<TextMesh>().text == "K"&& letter444.GetComponent<TextMesh>().text == "A" &&
            letter1111.GetComponent<TextMesh>().text == "B" && letter2222.GetComponent<TextMesh>().text == "A" && letter3333.GetComponent<TextMesh>().text == "T" &&
            letter4444.GetComponent<TextMesh>().text == "K" && letter5555.GetComponent<TextMesh>().text == "I" &&
            letter11111.GetComponent<TextMesh>().text == "B" && letter22222.GetComponent<TextMesh>().text == "A" && letter33333.GetComponent<TextMesh>().text == "T" &&
            letter44444.GetComponent<TextMesh>().text == "I" && letter55555.GetComponent<TextMesh>().text == "K" &&
            letter111111.GetComponent<TextMesh>().text == "A" && letter222222.GetComponent<TextMesh>().text == "K" &&
            letter333333.GetComponent<TextMesh>().text == "I" && letter444444.GetComponent<TextMesh>().text == "B" &&
            letter555555.GetComponent<TextMesh>().text == "E" && letter666666.GetComponent<TextMesh>().text == "T" 
            ) 
            
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore16"))
            {
                PlayerPrefs.SetString("name16", menu.namee);
                PlayerPrefs.SetFloat("highScore16", score);
                highScore16 = PlayerPrefs.GetFloat("highScore16");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "K";
            selectletter[2] = "A";
            selectletter[3] = "T";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "K";
            selectletter[2] = "I";
            selectletter[3] = "T";
            selectletter[4] = "A";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
            letter44.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "B";
            selectletter[2] = "E";
            selectletter[3] = "K";
            selectletter[4] = "A";
            letter111.GetComponent<TextMesh>().text = selectletter[1];
            letter222.GetComponent<TextMesh>().text = selectletter[2];
            letter333.GetComponent<TextMesh>().text = selectletter[3];
            letter444.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word3)
        {
            selectletter[1] = "B";
            selectletter[2] = "A";
            selectletter[3] = "T";
            selectletter[4] = "K";
            selectletter[5] = "I";
            letter1111.GetComponent<TextMesh>().text = selectletter[1];
            letter2222.GetComponent<TextMesh>().text = selectletter[2];
            letter3333.GetComponent<TextMesh>().text = selectletter[3];
            letter4444.GetComponent<TextMesh>().text = selectletter[4];
            letter5555.GetComponent<TextMesh>().text = selectletter[5];
        }
        if (currentWord == word4)
        {
            selectletter[1] = "B";
            selectletter[2] = "A";
            selectletter[3] = "T";
            selectletter[4] = "I";
            selectletter[5] = "K";
            letter11111.GetComponent<TextMesh>().text = selectletter[1];
            letter22222.GetComponent<TextMesh>().text = selectletter[2];
            letter33333.GetComponent<TextMesh>().text = selectletter[3];
            letter44444.GetComponent<TextMesh>().text = selectletter[4];
            letter55555.GetComponent<TextMesh>().text = selectletter[5];
        }
        if (currentWord == word5)
        {
            selectletter[1] = "A";
            selectletter[2] = "K";
            selectletter[3] = "I";
            selectletter[4] = "B";
            selectletter[5] = "E";
            selectletter[6] = "T";
            letter111111.GetComponent<TextMesh>().text = selectletter[1];
            letter222222.GetComponent<TextMesh>().text = selectletter[2];
            letter333333.GetComponent<TextMesh>().text = selectletter[3];
            letter444444.GetComponent<TextMesh>().text = selectletter[4];
            letter555555.GetComponent<TextMesh>().text = selectletter[5];
            letter666666.GetComponent<TextMesh>().text = selectletter[6];
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
        if (q == 0)
        {
            if (currentWord == word4)
            {
                q = 1;
                score += a;
                a = 0;
            }
        }
        if (r == 0)
        {
            if (currentWord == word5)
            {
                r = 1;
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
        random = Random.Range(0, 5);
        if (random == 3)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "I";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
            bottom4Obj.GetComponent<TextMesh>().text = "T";
            bottom5Obj.GetComponent<TextMesh>().text = "E";
            bottom6Obj.GetComponent<TextMesh>().text = "B";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "I";
            bottom2Obj.GetComponent<TextMesh>().text = "K";
            bottom3Obj.GetComponent<TextMesh>().text = "T";
            bottom4Obj.GetComponent<TextMesh>().text = "E";
            bottom5Obj.GetComponent<TextMesh>().text = "B";
            bottom6Obj.GetComponent<TextMesh>().text = "A";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "T";
            bottom3Obj.GetComponent<TextMesh>().text = "E";
            bottom4Obj.GetComponent<TextMesh>().text = "B";
            bottom5Obj.GetComponent<TextMesh>().text = "A";
            bottom6Obj.GetComponent<TextMesh>().text = "I";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "T";
            bottom2Obj.GetComponent<TextMesh>().text = "E";
            bottom3Obj.GetComponent<TextMesh>().text = "B";
            bottom4Obj.GetComponent<TextMesh>().text = "A";
            bottom5Obj.GetComponent<TextMesh>().text = "I";
            bottom6Obj.GetComponent<TextMesh>().text = "K";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "E";
            bottom2Obj.GetComponent<TextMesh>().text = "B";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
            bottom4Obj.GetComponent<TextMesh>().text = "I";
            bottom5Obj.GetComponent<TextMesh>().text = "K";
            bottom6Obj.GetComponent<TextMesh>().text = "T";
        }
        if (random == 5)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "B";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "I";
            bottom4Obj.GetComponent<TextMesh>().text = "K";
            bottom5Obj.GetComponent<TextMesh>().text = "T";
            bottom6Obj.GetComponent<TextMesh>().text = "E";
        }

    }
}