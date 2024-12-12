using Unity.Properties;
using UnityEngine;
using UnityEngine.UIElements;

public class GameLogic : MonoBehaviour
{
    public Ball ball;
    public UIDocument scoreBoard;

    [SerializeField]
    int playerScore;
    [SerializeField]
    int computerScore;

    public void playerScores(int score)
    {
        playerScore += score;
        Debug.Log("Player now has " + playerScore + " points");
        this.ball.Reset();
    }
    public void computerScores(int score)
    {
        computerScore += score;
        Debug.Log("Computer now has " + computerScore + " points");
        this.ball.Reset();
    }
}
