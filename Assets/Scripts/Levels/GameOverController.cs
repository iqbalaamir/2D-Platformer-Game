﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
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

    public void PlayerDied()
    {
        SoundManager.Instance.Play(Sounds.PlayerDeath);
        gameObject.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
