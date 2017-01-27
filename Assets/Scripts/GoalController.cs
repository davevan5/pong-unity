using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Text ScoreText;

    private int score;

    public void Reset()
    {
        score = 0;
        ScoreText.text = "0";
    }

    private void Start()
    {
        Reset();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Pong")
            return;

        var controller = collision.gameObject.GetComponent<PongController>();
        controller.Reset();

        score++;

        if (score > 10)
        {
            transform.parent.GetComponent<GoalsController>().RestartGame();
        }

        ScoreText.text = score.ToString();
    }


}
