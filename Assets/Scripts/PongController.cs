using UnityEngine;

public class PongController : MonoBehaviour
{
    private Rigidbody2D pongBody;

    void Start()
    {
        pongBody = GetComponent<Rigidbody2D>();
        pongBody.AddForce(new Vector2(700, 0));
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Player")
            return;

        var hitAdjust = 
            (transform.position.y - coll.gameObject.transform.position.y) * 100;

        pongBody.AddForce(new Vector2(0, hitAdjust));
    }
}
