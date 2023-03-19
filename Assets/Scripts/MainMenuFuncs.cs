using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFuncs : MonoBehaviour
{
    public GameObject optionsUI;
    public GameObject mainMenuUI;
    private void Start() {
        optionsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("Level");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options(){
        optionsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }
}
