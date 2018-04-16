using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ball : MonoBehaviour {
    public float speed = 10f;
    private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
//       if (this.randomNum == 0) {
//           rb.velocity = Vector2.right * speed;
//       } else {
//           rb.velocity = Vector2.left * speed;
//       }
	}

	// Update is called once per frame
	void Update () {
		
	}
}
