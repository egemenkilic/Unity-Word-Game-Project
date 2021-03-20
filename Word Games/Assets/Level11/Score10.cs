using UnityEngine;
using UnityEngine.UI;

public class Score10: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript10.score.ToString("f0");
        scoreTextUI.text = gmScript10.score.ToString("f0");
    }
}
