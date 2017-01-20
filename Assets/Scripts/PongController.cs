using UnityEngine;

public class PongController : MonoBehaviour {

    private Rigidbody2D pongBody;

    void Start () {
        pongBody = GetComponent<Rigidbody2D>();
        pongBody.AddForce(new Vector2(700, 0));
    }
}
