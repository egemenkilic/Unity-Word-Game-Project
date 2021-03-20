using UnityEngine;
using UnityEngine.UI;

public class Score12: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript12.score.ToString("f0");
        scoreTextUI.text = gmScript12.score.ToString("f0");
    }
}
