using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour
{
   
    private int score = 0;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private GameObject gameStartText;
    [SerializeField] private Text scoreText;

    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    private static GameCtrl instance;
    public static GameCtrl Instance => instance;

    private void Awake()
    {
        if (GameCtrl.instance != null)
        {
            Debug.LogError("Only one GameCtrl allow to exist");
            Destroy(gameObject);
        }
        GameCtrl.instance = this;

        
    }

  
    private void Update()
    {
        this.LoadScene();
    }

    
    public void GameStart()
    {
        if (InputManager.Instance.GetMouse())
        {
            gameStartText.SetActive(false);
            Debug.Log("GameStart");
        } 
            
    }
    
   

    public void LoadScene()
    {

        if (gameOver == true && InputManager.Instance.GetMouse())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScore()
    {
        if (gameOver) return;

        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

}


