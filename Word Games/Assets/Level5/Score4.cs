using UnityEngine;
using UnityEngine.UI;

public class Score4: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript4.score.ToString("f0");
        scoreTextUI.text = gmScript4.score.ToString("f0");
    }
}
