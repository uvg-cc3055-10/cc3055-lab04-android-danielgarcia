using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
    Rigidbody2D rb;
    float speed = 5.0f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.gameOver = true;

    }
}
