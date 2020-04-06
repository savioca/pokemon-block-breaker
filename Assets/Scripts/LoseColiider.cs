using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColiider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //FindObjectOfType<SceneLoader>().CenaAtual = SceneManager.GetActiveScene().buildIndex;
        FindObjectOfType<GameSession>().scoreText.text = "0";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }    
}

public class Scenes
{
    public const string GameOver = "Game Over";
}
