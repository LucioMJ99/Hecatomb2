using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        Shield shield = hitInfo.GetComponent<Shield>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        else if (shield != null)
        {
            shield.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void OnBecomeInvisible()
    {
        Destroy(gameObject);
        Debug.Log("pene");
    }
}
