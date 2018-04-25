using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    public Button playGameButton;
    public Text highscoreText;
    float highscore;

    // Use this for initialization
    void Start()
    {
        Button btn = playGameButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        highscore = PlayerPrefs.GetFloat("highscore", 0.0f);
        highscoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene("GameLevel", LoadSceneMode.Single);
    }
}
