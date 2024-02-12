using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Beam : MonoBehaviour
{
    public float speed = 1000f;
    public float damage = 20f;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = transform.right * speed;   
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.name);
        Pierce pierce = collision.GetComponent<Pierce>();
        Player player = collision.GetComponent<Player>();
        if(pierce != null)
        {
            pierce.TakeDamage(damage);
        }
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
