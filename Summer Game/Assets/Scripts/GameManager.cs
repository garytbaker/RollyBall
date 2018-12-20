using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartTime;
    public GameObject winScreen;
    public static int levelNumber;
    public void Lost()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartTime);
        }
    }
    public void Win()
    {
        winScreen.SetActive(true);
    }

    public void ChangeLevel()
    {
        GameManager.levelNumber += 1;
        if (GameManager.levelNumber > 1)
        {
            Win();
        }
        else
        {
            SceneManager.LoadScene(levelNumber);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
