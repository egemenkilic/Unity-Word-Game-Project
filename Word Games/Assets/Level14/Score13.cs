using UnityEngine;
using UnityEngine.UI;

public class Score13: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript13.score.ToString("f0");
        scoreTextUI.text = gmScript13.score.ToString("f0");
    }
}
