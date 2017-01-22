using UnityEngine;

public class GoalController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Pong")
            return;

        var controller = collision.gameObject.GetComponent<PongController>();

        controller.Reset();
    }
}
