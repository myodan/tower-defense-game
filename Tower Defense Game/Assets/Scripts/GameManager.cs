using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject completeLevelUI;

    public static bool GameIsOver = false;

    private CompleteLevel completeLevel;

    private void Start()
    {
        GameIsOver = false;
        completeLevel = completeLevelUI.GetComponent<CompleteLevel>();
    }

    private void Update()
    {
        if (GameIsOver)
        {
            return;
        }

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", completeLevel.levelToUnlock);
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
