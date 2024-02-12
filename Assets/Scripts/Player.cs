using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float health = 100.0f;

    public GameObject healthBar;
    public bool isAlive = true;


    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.transform.localScale = new Vector3(health / 100, 1, 1);
        if (health <= 0)
        {
            Die();
            
            SceneManager.LoadScene(0, LoadSceneMode.Single);

        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
