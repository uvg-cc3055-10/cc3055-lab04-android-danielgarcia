using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    private float scrollingSpeed = 4.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            transform.Translate(Vector3.down * scrollingSpeed * Time.deltaTime);
            if (transform.position.x < -8)
            {
                Destroy(gameObject);
            }
        }
    }
}
