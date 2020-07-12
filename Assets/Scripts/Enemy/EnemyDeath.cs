using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDeath : MonoBehaviour
{
    public float speed;
    public bool moveRight;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>() != null)
        {
            Destroy(collision.gameObject);
            Debug.Log("enemy dies");
            
        }
        if(collision.gameObject.CompareTag("walls"))
        {
            moveRight = true;
            Debug.Log("Wall Touched Left");
        }

    }
    
    private void Update()
    {
        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed , 0, 0);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            moveRight = false;
            Debug.Log("Wall Touched");
        }
       
    }
}
