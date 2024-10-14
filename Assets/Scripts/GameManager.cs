using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] Paddle player1Paddle;
    [SerializeField] Paddle player2Paddle;
    [SerializeField] Text player1scoreText;
    [SerializeField] Text player2scoreText;
    private int player1score;
    private int player2score;

    public void Player1Scores()
    {
        player1score++;
        this.player1scoreText.text = player1score.ToString();
        ResetRound();
    }

    public void Player2Scores()
    {
        player2score++;
        this.player2scoreText.text = player2score.ToString();
        ResetRound();

    }
    public void ResetRound()
    {
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.player1Paddle.ResetPosition();
        this.player2Paddle.ResetPosition();
    }
}