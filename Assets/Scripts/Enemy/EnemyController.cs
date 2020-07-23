using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float direction;
    public float speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<PlayerController>() !=null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.KillPlayer();
        }
       
    }
    private void Update()
    {
        EnemyWalk();
    }
    void EnemyWalk()
    {
        Vector2 position = transform.position;
        position.x += direction * speed * Time.deltaTime;
        transform.position = position;
    }

    public void Flip()
    {
        direction = -direction;
        Vector3 scale = transform.localScale;
        scale.x = -scale.x;
        transform.localScale = scale;
    }
}
