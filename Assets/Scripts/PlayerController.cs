using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int PlayerNumber = 1;

    public float Speed = 30.0f;

    private Rigidbody2D playerBody;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        var v = Input.GetAxis("Vertical" + PlayerNumber);

        if ((playerBody.position.y > 15 && v > 0) || (playerBody.position.y < -15 && v < 0))
            playerBody.velocity = new Vector2(0, 0);
        else
            playerBody.velocity = new Vector2(0, v) * Speed;
    }
}
