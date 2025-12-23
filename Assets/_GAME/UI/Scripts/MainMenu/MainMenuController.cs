using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private string gameSceneName = "02_FirstLevel";
    public void onStartClick()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void onExitClick()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }
}
