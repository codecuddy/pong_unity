using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour {
    public float speed = 10f;
    private Rigidbody2D rb;
    private int direction = 1;
    public int leftScore = 0;
    public int rightScore = 0;
    public Text leftText;
    public Text rightText;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2);
    }

    void StartBall() {
        //ensure paddles are back to center
        rb.velocity = new Vector2(direction, 0) * speed; 
    }

	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D (Collision2D obj) {
        if (obj.gameObject.tag == "paddleRight") {
            float y = (transform.position.y - obj.transform.position.y) / obj.collider.bounds.size.y;
            Vector2 dir = new Vector2(-1, y).normalized;
            rb.velocity = dir * speed;
        }
        if (obj.gameObject.tag == "paddleLeft") {
            float y = (transform.position.y - obj.transform.position.y) / obj.collider.bounds.size.y;
            Vector2 dir = new Vector2(1, y).normalized;
            rb.velocity = dir * speed;
        }
        if (obj.gameObject.tag == "wallRight") {
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = Vector2.zero;
            direction = 1;
            Invoke("StartBall", 1);
            if (leftScore < 11) {
                leftScore++;
                leftText.text = leftScore.ToString();
            }
            if (leftScore == 11 ) {
                leftText.text = "Winner!";
            }

        }
        if (obj.gameObject.tag == "wallLeft") {
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = Vector2.zero;
            direction = -1;
            Invoke("StartBall", 1);
            if (rightScore < 11) {
                rightScore++;
                rightText.text = rightScore.ToString();
            }
            if (rightScore == 11) {
                rightText.text = "Winner!";
            }
        }
    }
}
