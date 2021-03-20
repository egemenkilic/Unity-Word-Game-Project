using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript2.score.ToString("f0");
        scoreTextUI.text = gmScript2.score.ToString("f0");
    }
}
