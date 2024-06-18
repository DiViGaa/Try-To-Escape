using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private string sceneName;
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void FillSceneName(string sceneName)
    {
        this.sceneName = sceneName;
    }
}
