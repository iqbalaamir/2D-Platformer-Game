
﻿using UnityEngine;




public class LevelOverControl : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() !=null)
        {
            Debug.Log("Level Crossed");

            LevelManager.Instance.MarkCurrentLevelComplete();
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.LevelClear();

        }
    }
}
