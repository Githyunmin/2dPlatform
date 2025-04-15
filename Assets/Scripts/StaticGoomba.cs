using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class StaticGoomba : MonoBehaviour
{
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();

            if (collision.transform.DotTest(transform, Vector2.down))
            {
                Falloff();
            }
            else
            {
                player.Hit();
            }
        }
    }

  

    private void Falloff()
    {
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 0.5f);

    }

    private void Hit()
    {
        GetComponent<AnimatedSprite>().enabled = false;
        GetComponent<DeathAnimation>().enabled = true;
        Destroy(gameObject, 3f);
    }
}
