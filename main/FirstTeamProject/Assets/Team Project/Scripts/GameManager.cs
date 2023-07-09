using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;
    public Text score;
    public Text Best_score;
    public Text life;

    private int score_number;
    private int life_number;
    private bool isGameover;

    void Start()
    {
        score_number = 0;
        life_number = 5;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {
            score.text = string.Format("Score : {0}", (int)score_number);
            life.text = string.Format("Life : {0}", (int)life_number);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        int best_score = PlayerPrefs.GetInt("BestScore");

        if (score_number > best_score)
        {
            best_score = score_number;
            PlayerPrefs.SetInt("BestScore", best_score);

            Best_score.text = string.Format("Best Score : {0}", (int)best_score);
        }
    }

    public void ScorePlus()
    {
        score_number += 1;
    }

    public void LifeDown()
    {
        life_number -= 1;

        if (life_number == 0)
        {
            EndGame();
        }
    }
}
