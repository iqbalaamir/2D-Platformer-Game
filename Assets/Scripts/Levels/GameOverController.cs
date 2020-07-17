<<<<<<< Updated upstream
﻿using UnityEngine;
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        
=======
>>>>>>> Stashed changes
    }

    public void PlayerDied()
    {

        gameObject.SetActive(true);
    }

    public void ReloadScene()
    {
<<<<<<< Updated upstream
      Scene scene =  SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
   
=======
        SceneManager.LoadScene(Scene);
    }
>>>>>>> Stashed changes
}
