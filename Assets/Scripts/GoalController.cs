using UnityEngine;
using UnityEngine.UI;

public class GoalController : MonoBehaviour
{
    public Text ScoreText;

    private int score;

    private void Start()
    {
        ScoreText.text = "0";
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Pong")
            return;

        score++;
        ScoreText.text = score.ToString();

        var controller = collision.gameObject.GetComponent<PongController>();
        controller.Reset();
    }
}
