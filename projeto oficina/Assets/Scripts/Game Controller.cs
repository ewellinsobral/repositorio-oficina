using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;
   
    public static GameController instance;
   
    void Start()
    {
        instance = this;
    }

  
    void Update()
    {
        
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }
    public void Restart(string nomelvl ){
        SceneManager.LoadScene(nomelvl);
    }

  
}
