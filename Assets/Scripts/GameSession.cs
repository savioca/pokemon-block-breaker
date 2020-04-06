using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameSession : MonoBehaviour{
    
    //config parameters
 [Range(0.1f, 10f)]   [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlocksDestroyed = 14;
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;
   
    //state variables
    [SerializeField] int currentScore = 0;
        private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore = currentScore + pointsPerBlocksDestroyed;
        scoreText.text = currentScore.ToString();
        // ou currentScore += pointsPerBlockDestroyed
    }
    public void RestartGame()
    {
        Destroy(gameObject);
    }
    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
