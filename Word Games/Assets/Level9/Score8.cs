using UnityEngine;
using UnityEngine.UI;

public class Score8: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript8.score.ToString("f0");
        scoreTextUI.text = gmScript8.score.ToString("f0");
    }
}
