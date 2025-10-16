using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UIElements;
public class MenuManager : MonoBehaviour
{
    public TMP_Text panelname;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
    public void SetPanelName(string name)
    {
        panelname.text = name;
    }
}
