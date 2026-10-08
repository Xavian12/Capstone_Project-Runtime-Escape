using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OnExitClick()
    {
# if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
# endif 
        Application.Quit();
    }
}
