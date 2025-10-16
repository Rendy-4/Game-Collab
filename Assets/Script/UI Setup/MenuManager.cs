using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UIElements;
public class MenuManager : MonoBehaviour
{

    public void LoadScenePanel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
