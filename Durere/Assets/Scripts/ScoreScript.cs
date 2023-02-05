using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public float PointIncreasedPerSecond = 0.2f;

    private void Start()
    {
        scoreAmount =0f;
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (scoreAmount <2) 
            scoreText.text = (int)scoreAmount + " Year";
        else 
            scoreText.text = (int)scoreAmount + " Years";

        scoreAmount += PointIncreasedPerSecond * Time.deltaTime;
    }
}