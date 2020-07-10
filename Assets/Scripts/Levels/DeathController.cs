using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public string Scene;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(Scene);
            Debug.Log("Player Died");
                
        }
        
    }
}
