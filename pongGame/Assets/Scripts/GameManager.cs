using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text _playerScoreText;
    public Text _aiScoreText;
    private int _playerScore;
    private int _aiScore;

    public void PlayerScores() {
        _playerScore++;
        _playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        this.ball.InitialForce();
    }
    
    public void AIScores() {
        _aiScore++;
        _aiScoreText.text = _aiScore.ToString();
        this.ball.ResetPosition();
        this.ball.InitialForce();
    }
}
