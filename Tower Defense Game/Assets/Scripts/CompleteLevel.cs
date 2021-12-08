using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public SceneFader sceneFader;

    public string nextLevel = "Level02";
    public int levelToUnlock = 2;

    public void LevelSelect()
    {
        sceneFader.FadeTo("LevelSelectScene");
    }

    public void NextLevel()
    {
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
    }

    public void Title()
    {
        sceneFader.FadeTo("TitleScene");
    }

}
