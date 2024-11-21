using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public Ball ball; 

    private int _playerScore = 0;
    private int _computerScore = 0;

    public void playerScores(int score)
    {
        _playerScore += score;
        Debug.Log("Player now has " + _playerScore + " points");
        this.ball.Reset();
    }
    public void computerScores(int score)
    {
        _computerScore += score;
        Debug.Log("Computer now has " + _computerScore + " points");
        this.ball.Reset();
    }
}
