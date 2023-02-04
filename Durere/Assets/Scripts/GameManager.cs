using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _score;

    public void GameOver()
    {
        print("you lose");
    }

    public void AddScore()
    {
        _score++;
    }
}

