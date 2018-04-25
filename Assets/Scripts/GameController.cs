using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {
    public bool gameOver = false;
    public float score = 0.0f;
    public static GameController instance;

    // Use this for initialization
    void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOver == true)
        {
            PlayerPrefs.SetFloat("highscore", score);
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}
