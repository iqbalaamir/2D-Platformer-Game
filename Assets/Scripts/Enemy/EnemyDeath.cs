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

    }
    
    private void Update()
    {
        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed , 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }
}
