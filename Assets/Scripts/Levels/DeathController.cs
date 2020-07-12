using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class DeathController : MonoBehaviour
{
    public Animator animator;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            animator.SetBool("Dead", true);
            Destroy(collision.gameObject);
            Debug.Log("Player Died");
           
            
            

                
        }
       
        
    }
}
