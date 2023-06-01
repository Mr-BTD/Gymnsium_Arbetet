using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public bool gameHasStarted = false;
    public Text scoreText;
    public GameObject gameOverObject;
    public GameObject countObject;
    public GameObject startScreen;


    public void Update()
    {
        if (gameHasStarted == false)
        {
            countObject.SetActive(false);
            startScreen.SetActive(true);
        }
        else if (gameHasStarted == true)
        {
            countObject.SetActive(true);
            startScreen.SetActive(false);
        }
    }


    [ContextMenu("Increase Score")]
    public void addScore(int toAddscore)
    {
        playerScore = playerScore + toAddscore;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverObject.SetActive(true);
    }
    public void gameStart()
    {
        gameHasStarted = true;
    }
}