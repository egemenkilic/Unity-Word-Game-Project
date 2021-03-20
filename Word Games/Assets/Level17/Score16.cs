using UnityEngine;
using UnityEngine.UI;

public class Score16: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript16.score.ToString("f0");
        scoreTextUI.text = gmScript16.score.ToString("f0");
    }
}
