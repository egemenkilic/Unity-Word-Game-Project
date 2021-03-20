using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript16 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "İN";
    public string word1 = "NAL";
    public string word2 = "MANİ";
    public string word3 = "ALİM";
    public string word4 = "BİNA";
    public string word5 = "ALBÜM";
    public string word6 = "LİMAN";
    public string word7 = "ALBÜMİN";

    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" , "", "", ""};
    public static int letterNum = 0;

    public Transform letter1; //İ
    public Transform letter2; //N
    
    public Transform letter11; //N
    public Transform letter22; //A
    public Transform letter33; //L

    public Transform letter111; //M
    public Transform letter222; //A
    public Transform letter333; //N
    public Transform letter444; //İ

    public Transform letter1111; //A
    public Transform letter2222; //L
    public Transform letter3333; //İ
    public Transform letter4444; //M

    public Transform letter11111; //B
    public Transform letter22222; //İ
    public Transform letter33333; //N
    public Transform letter44444; //A

    public Transform letter111111; //A
    public Transform letter222222; //L
    public Transform letter333333; //B
    public Transform letter444444; //Ü
    public Transform letter555555; //M

    public Transform letter1111111; //L
    public Transform letter2222222; //İ
    public Transform letter3333333; //M
    public Transform letter4444444; //A
    public Transform letter5555555; //N

    public Transform letter11111111; //A
    public Transform letter22222222; //L
    public Transform letter33333333; //B
    public Transform letter44444444; //Ü
    public Transform letter55555555; //M
    public Transform letter66666666; //İ
    public Transform letter77777777; //N

    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public Transform bottom4Obj;
    public Transform bottom5Obj;
    public Transform bottom6Obj;
    public Transform bottom7Obj;

    public static float score=0;
    public static float a=0;
    public static float highScore17;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0, z = 0, p = 0, k=0, q=0, r=0, m=0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 18;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "A";
        bottom2Obj.GetComponent<TextMesh>().text = "L";
        bottom3Obj.GetComponent<TextMesh>().text = "B";
        bottom4Obj.GetComponent<TextMesh>().text = "Ü";
        bottom5Obj.GetComponent<TextMesh>().text = "M";
        bottom6Obj.GetComponent<TextMesh>().text = "İ";
        bottom7Obj.GetComponent<TextMesh>().text = "N";

        highScore17 = PlayerPrefs.GetFloat("highScore17");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="İ" && letter2.GetComponent<TextMesh>().text=="N" &&
            letter11.GetComponent<TextMesh>().text == "N" && letter22.GetComponent<TextMesh>().text == "A" && letter33.GetComponent<TextMesh>().text == "L" &&
            letter111.GetComponent<TextMesh>().text == "M" && letter222.GetComponent<TextMesh>().text == "A" && 
            letter333.GetComponent<TextMesh>().text == "N"&& letter444.GetComponent<TextMesh>().text == "İ" &&
            letter1111.GetComponent<TextMesh>().text == "A" && letter2222.GetComponent<TextMesh>().text == "L" &&
            letter3333.GetComponent<TextMesh>().text == "İ" && letter4444.GetComponent<TextMesh>().text == "M" &&
            letter11111.GetComponent<TextMesh>().text == "B" && letter22222.GetComponent<TextMesh>().text == "İ" &&
            letter33333.GetComponent<TextMesh>().text == "N" && letter44444.GetComponent<TextMesh>().text == "A" &&
            letter111111.GetComponent<TextMesh>().text == "A" && letter222222.GetComponent<TextMesh>().text == "L" &&
            letter333333.GetComponent<TextMesh>().text == "B" && letter444444.GetComponent<TextMesh>().text == "Ü" && letter555555.GetComponent<TextMesh>().text == "M" &&
            letter1111111.GetComponent<TextMesh>().text == "L" && letter2222222.GetComponent<TextMesh>().text == "İ" &&
            letter3333333.GetComponent<TextMesh>().text == "M" && letter4444444.GetComponent<TextMesh>().text == "A" && letter5555555.GetComponent<TextMesh>().text == "N" &&
            letter11111111.GetComponent<TextMesh>().text == "A" && letter22222222.GetComponent<TextMesh>().text == "L" &&
            letter33333333.GetComponent<TextMesh>().text == "B" && letter44444444.GetComponent<TextMesh>().text == "Ü" && 
            letter55555555.GetComponent<TextMesh>().text == "M" && letter66666666.GetComponent<TextMesh>().text == "İ" &&
            letter77777777.GetComponent<TextMesh>().text == "N"
            )
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore17"))
            {
                PlayerPrefs.SetString("name17", menu.namee);
                PlayerPrefs.SetFloat("highScore17", score);
                highScore17 = PlayerPrefs.GetFloat("highScore17");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "İ";
            selectletter[2] = "N";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            
        }

        if (currentWord == word1)
        {
            selectletter[1] = "N";
            selectletter[2] = "A";
            selectletter[3] = "L";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word2)
        {
            selectletter[1] = "M";
            selectletter[2] = "A";
            selectletter[3] = "N";
            selectletter[4] = "İ";
            letter111.GetComponent<TextMesh>().text = selectletter[1];
            letter222.GetComponent<TextMesh>().text = selectletter[2];
            letter333.GetComponent<TextMesh>().text = selectletter[3];
            letter444.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word3)
        {
            selectletter[1] = "A";
            selectletter[2] = "L";
            selectletter[3] = "İ";
            selectletter[4] = "M";
            letter1111.GetComponent<TextMesh>().text = selectletter[1];
            letter2222.GetComponent<TextMesh>().text = selectletter[2];
            letter3333.GetComponent<TextMesh>().text = selectletter[3];
            letter4444.GetComponent<TextMesh>().text = selectletter[4];
        }

        if (currentWord == word4)
        {
            selectletter[1] = "B";
            selectletter[2] = "İ";
            selectletter[3] = "N";
            selectletter[4] = "A";
            letter11111.GetComponent<TextMesh>().text = selectletter[1];
            letter22222.GetComponent<TextMesh>().text = selectletter[2];
            letter33333.GetComponent<TextMesh>().text = selectletter[3];
            letter44444.GetComponent<TextMesh>().text = selectletter[4];
        }
        if (currentWord == word5)
        {
            selectletter[1] = "A";
            selectletter[2] = "L";
            selectletter[3] = "B";
            selectletter[4] = "Ü";
            selectletter[5] = "M";
            letter111111.GetComponent<TextMesh>().text = selectletter[1];
            letter222222.GetComponent<TextMesh>().text = selectletter[2];
            letter333333.GetComponent<TextMesh>().text = selectletter[3];
            letter444444.GetComponent<TextMesh>().text = selectletter[4];
            letter555555.GetComponent<TextMesh>().text = selectletter[5];
        }
        if (currentWord == word6)
        {
            selectletter[1] = "L";
            selectletter[2] = "İ";
            selectletter[3] = "M";
            selectletter[4] = "A";
            selectletter[5] = "N";
            letter1111111.GetComponent<TextMesh>().text = selectletter[1];
            letter2222222.GetComponent<TextMesh>().text = selectletter[2];
            letter3333333.GetComponent<TextMesh>().text = selectletter[3];
            letter4444444.GetComponent<TextMesh>().text = selectletter[4];
            letter5555555.GetComponent<TextMesh>().text = selectletter[5];
        }
        if (currentWord == word7)
        {
            selectletter[1] = "A";
            selectletter[2] = "L";
            selectletter[3] = "B";
            selectletter[4] = "Ü";
            selectletter[5] = "M";
            selectletter[6] = "İ";
            selectletter[7] = "N";
            letter11111111.GetComponent<TextMesh>().text = selectletter[1];
            letter22222222.GetComponent<TextMesh>().text = selectletter[2];
            letter33333333.GetComponent<TextMesh>().text = selectletter[3];
            letter44444444.GetComponent<TextMesh>().text = selectletter[4];
            letter55555555.GetComponent<TextMesh>().text = selectletter[5];
            letter66666666.GetComponent<TextMesh>().text = selectletter[6];
            letter77777777.GetComponent<TextMesh>().text = selectletter[7];
            
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
        if (q == 0)
        {
            if (currentWord == word5)
            {
                q = 1;
                score += a;
                a = 0;
            }
        }
        if (r == 0)
        {
            if (currentWord == word6)
            {
                r = 1;
                score += a;
                a = 0;
            }
        }
        if (m == 0)
        {
            if (currentWord == word7)
            {
                m = 1;
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
        random = Random.Range(0, 6);
        if (random == 3)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "A";
            bottom2Obj.GetComponent<TextMesh>().text = "Ü";
            bottom3Obj.GetComponent<TextMesh>().text = "L";
            bottom4Obj.GetComponent<TextMesh>().text = "B";
            bottom5Obj.GetComponent<TextMesh>().text = "İ";
            bottom6Obj.GetComponent<TextMesh>().text = "N";
            bottom7Obj.GetComponent<TextMesh>().text = "M";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ü";
            bottom2Obj.GetComponent<TextMesh>().text = "L";
            bottom3Obj.GetComponent<TextMesh>().text = "B";
            bottom4Obj.GetComponent<TextMesh>().text = "İ";
            bottom5Obj.GetComponent<TextMesh>().text = "N";
            bottom6Obj.GetComponent<TextMesh>().text = "M";
            bottom7Obj.GetComponent<TextMesh>().text = "A";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "L";
            bottom2Obj.GetComponent<TextMesh>().text = "B";
            bottom3Obj.GetComponent<TextMesh>().text = "İ";
            bottom4Obj.GetComponent<TextMesh>().text = "N";
            bottom5Obj.GetComponent<TextMesh>().text = "M";
            bottom6Obj.GetComponent<TextMesh>().text = "A";
            bottom7Obj.GetComponent<TextMesh>().text = "Ü";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "B";
            bottom2Obj.GetComponent<TextMesh>().text = "İ";
            bottom3Obj.GetComponent<TextMesh>().text = "N";
            bottom4Obj.GetComponent<TextMesh>().text = "M";
            bottom5Obj.GetComponent<TextMesh>().text = "A";
            bottom6Obj.GetComponent<TextMesh>().text = "Ü";
            bottom7Obj.GetComponent<TextMesh>().text = "L";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "İ";
            bottom2Obj.GetComponent<TextMesh>().text = "N";
            bottom3Obj.GetComponent<TextMesh>().text = "M";
            bottom4Obj.GetComponent<TextMesh>().text = "A";
            bottom5Obj.GetComponent<TextMesh>().text = "Ü";
            bottom6Obj.GetComponent<TextMesh>().text = "L";
            bottom7Obj.GetComponent<TextMesh>().text = "B";
        }
        if (random == 5)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "N";
            bottom2Obj.GetComponent<TextMesh>().text = "M";
            bottom3Obj.GetComponent<TextMesh>().text = "A";
            bottom4Obj.GetComponent<TextMesh>().text = "Ü";
            bottom5Obj.GetComponent<TextMesh>().text = "L";
            bottom6Obj.GetComponent<TextMesh>().text = "B";
            bottom7Obj.GetComponent<TextMesh>().text = "İ";
        }
        if (random == 6)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "M";
            bottom2Obj.GetComponent<TextMesh>().text = "A";
            bottom3Obj.GetComponent<TextMesh>().text = "Ü";
            bottom4Obj.GetComponent<TextMesh>().text = "L";
            bottom5Obj.GetComponent<TextMesh>().text = "B";
            bottom6Obj.GetComponent<TextMesh>().text = "İ";
            bottom7Obj.GetComponent<TextMesh>().text = "N";
        }

    }
}