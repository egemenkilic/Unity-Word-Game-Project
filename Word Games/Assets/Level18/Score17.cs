using UnityEngine;
using UnityEngine.UI;

public class Score17: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript17.score.ToString("f0");
        scoreTextUI.text = gmScript17.score.ToString("f0");
    }
}
