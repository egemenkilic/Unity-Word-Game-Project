using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript.score.ToString("f0");
        scoreTextUI.text = gmScript.score.ToString("f0");
    }
}
