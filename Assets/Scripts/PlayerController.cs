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
        float v = Input.GetAxis("Vertical" + PlayerNumber);
        playerBody.velocity = new Vector2(0, v) * Speed;
    }
}
