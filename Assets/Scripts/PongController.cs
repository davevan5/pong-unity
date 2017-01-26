using UnityEngine;

public class PongController : MonoBehaviour
{
    public float Speed = 30.0f;

    private Rigidbody2D pongBody;

    public void Reset()
    {
        pongBody.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }

    private void Start()
    {
        pongBody = GetComponent<Rigidbody2D>();
        Serve();
    }

    private void FixedUpdate()
    {
        pongBody.velocity = pongBody.velocity.normalized * Speed;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            Serve();
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Player")
            return;

        var hitAdjust = (transform.position.y - coll.gameObject.transform.position.y) * 3;

        pongBody.AddForce(new Vector2(0, hitAdjust));
    }

    private void Serve()
    {
        var direction = Random.Range(0, 2) * 2 - 1;
        var x = Random.Range(0.5f, 1.0f) * direction;
        var y = Random.Range(0.0f, 0.5f);

        pongBody.velocity = new Vector2(x, y);
        pongBody.velocity = pongBody.velocity.normalized * Speed;
    }
}
