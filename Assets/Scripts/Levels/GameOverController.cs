using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
   public string Scene;
   public Button buttonRestart;
   

    private void Awake()
    {
        gameObject.SetActive(false);
        buttonRestart.onClick.AddListener(ReloadScene);
        
    }

    public void PlayerDied()
    {

        gameObject.SetActive(true);
    }

    public void ReloadScene()
    {
      Scene scene =  SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
   
}
