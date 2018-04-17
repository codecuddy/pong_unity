using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float speed = 10f;
    private Rigidbody2D rb;
    private float randomNumber;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        randomNumber = Random.Range(1, 3);
          if (randomNumber == 1) {
            Debug.Log(randomNumber);
             rb.velocity = Vector2.right * speed;
          } if (randomNumber == 2) {
            Debug.Log(randomNumber);
             rb.velocity = Vector2.left * speed;
          }
	 }

	// Update is called once per frame
	void Update () {
		
	}
}
