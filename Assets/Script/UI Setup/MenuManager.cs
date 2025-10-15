using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_Text panelname;
    public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public void ExitApp()
    {
        Application.Quit();
    }

    public void setPanelName(string name)
    {
        panelname.text = name;
    }
}   
