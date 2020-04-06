using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] public int CenaAtual = 1;
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        CenaAtual = currentSceneIndex + 1;
        SceneManager.LoadScene(CenaAtual);
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(CenaAtual);
        FindObjectOfType<GameSession>().RestartGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}