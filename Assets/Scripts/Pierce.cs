using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pierce : MonoBehaviour
{
    public float health = 100.0f;
    public Transform firePoint;
    public GameObject beamPrefab;
    public Transform parent;
    public GameObject beamClone;
    public float timer = 0;
    public int waitingTime = 2;
    public GameObject healthBar;
    public static bool isAlive = true;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime)
        {
            ShootEnemy();
            timer = 0;
             
        }
        

    }
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.transform.localScale = new Vector3(health / 100, 1, 1);
        //Debug.Log("Scene: " + SceneManager.GetActiveScene().name);
        if(health <= 0 && SceneManager.GetActiveScene().name == "Level1")
        {
            Die();
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
        else if (health <= 0 && SceneManager.GetActiveScene().name == "Level2")
        {
            Die();
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
        else if (health <= 0 && SceneManager.GetActiveScene().name == "Level3")
        {
            Die();
            SceneManager.LoadScene(4, LoadSceneMode.Single);
        }
        else if (health <= 0 && SceneManager.GetActiveScene().name == "Final")
        {
            Die();
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
    public void Die()
    {
        isAlive = false;
        Destroy(gameObject);
        
    }
    void ShootEnemy()
    {
        beamClone = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
        beamClone.transform.SetParent(parent);
        
    }
}
