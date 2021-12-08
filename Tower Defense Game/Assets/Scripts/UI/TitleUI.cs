using UnityEngine;

public class TitleUI : MonoBehaviour
{
    public SceneFader sceneFader;

    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
        sceneFader.FadeTo("LevelSelectScene");
    }

    public void Continue()
    {
        sceneFader.FadeTo("LevelSelectScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
