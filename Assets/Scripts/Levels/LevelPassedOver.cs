using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPassedOver : MonoBehaviour
{
    public string Scene;
    public Button buttonRestart;
    public Button Lobby;


    private void Awake()
    {
        gameObject.SetActive(false);
        buttonRestart.onClick.AddListener(ReloadScene);
        Lobby.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LevelPassed()
    {
        Debug.Log("Level Finished");
        gameObject.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
