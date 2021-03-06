﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public ScoreController scoreController;
    public GameOverController gameOverController;
    public LevelPassedOver LevelPassedOver;
    public PlayerHealth playerHealth;

    public Animator animator;
    public BoxCollider2D boxcollider;
    public float speed;

    public void LevelClear()
    {
        LevelPassedOver.LevelPassed();
    }

    public float jump;
    public float sizeSit ;

   


    public float offsetSit ;
    public float sizeStand ;
    public float offsetStand ;


    private bool isOnGround;
    private bool jumpInitaited;
    private Vector2 spawnPosition;
    public int score;
    private Vector3 respawn;


    private void Awake()
    {
        Debug.Log("Player controller awake");
        rb2d=gameObject.GetComponent<Rigidbody2D>();
        boxcollider=gameObject.GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");
        MoveCharacter(horizontal,vertical);
        PlayMovementAnimation(horizontal, vertical);
    }
    private void MoveCharacter(float horizontal,float vertical)
    {
        Vector3 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;
        transform.position = position;
        if(vertical > 0)
        {
            if(isOnGround)
            rb2d.AddForce(Vector2.up * jump);
        }                  
    }

    private void PlayMovementAnimation(float horizontal,float vertical)
    {
        
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        

        Vector3 scale = transform.localScale;

        if (horizontal < 0)
        {
            SoundManager.Instance.Play(Sounds.PlayerMove); 

            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }

        transform.localScale = scale;

       if (vertical > 0 )
        {
            animator.SetBool("Jump", true);

        }
        else
        {
            animator.SetBool("Jump", false);
        }
        if (Input.GetKey(KeyCode.LeftControl) == true)
        {
            animator.SetBool("isSit", true);
            boxcollider.size = new Vector2(boxcollider.size.x, sizeSit);
            boxcollider.offset = new Vector2(boxcollider.offset.x, offsetSit);

        }
        else
        {
            animator.SetBool("isSit", false);
            boxcollider.offset = new Vector2(boxcollider.offset.x, sizeStand);
            boxcollider.size = new Vector2(boxcollider.size.x, offsetStand);
        }

    }
    private void OnCollisionEnter2D(Collision2D ground)
    {
        if (ground.gameObject.layer== 8)
        {
            isOnGround = true;
            Debug.Log("Onground");
        }
       
    }
   
    private void OnCollisionExit2D(Collision2D ground)
    {
        if (ground.gameObject.layer == 8)
        {
            isOnGround = false;
        }
    }

    public void KillPlayer()
    {
        if (playerHealth.health !=1)

        {
            playerHealth.ReduceHealth();
            transform.position = respawn;
        }
        else
        {
            gameOverController.PlayerDied();
            animator.SetBool("Dead", true);
            gameObject.SetActive(false);
            Debug.Log("Player Died By Enemy");
            
        }
    }
    public void PickUpKey()
    {
        
        Debug.Log("Picked Up Key");
        scoreController.AddScore(score);
    }
}
