using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public GameObject asteroid;
    private float spawnTime = 4.0f;
    private float elapsedTime = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            if (elapsedTime < spawnTime)
            {
                elapsedTime = elapsedTime + Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                Instantiate(asteroid, new Vector3(random, 4, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }
    }
}
