using UnityEngine;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button PlayButton;
    public GameObject LevelSelection;

    private void Awake()
    {
        PlayButton.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        LevelSelection.SetActive( true );

    }
}
