using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class leftPaddle : MonoBehaviour {
    public float speed = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w") && transform.position.y < 3.75) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey("s") && transform.position.y > -3.75) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("a") && transform.position.x > -6) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d") && transform.position.x < -0.5) {
            //Time.deltaTime is computer time in seconds so if there is lag it stay consistent
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
	}
}
