using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    public Transform spawnPointEnemy;
    public Transform parent;
    public GameObject enemy;
    public GameObject clone;
    //public float movementSpeed = 200.0f;


    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        //Debug.Log(selectedCharacter);

        GameObject prefab = characterPrefabs[selectedCharacter];
        clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        clone.transform.position = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, 0);
        clone.transform.SetParent(parent);
        clone.transform.localScale = new Vector3(1,1,1);

        GameObject cloneEnemy = Instantiate(enemy,spawnPointEnemy.position, Quaternion.identity);

        cloneEnemy.transform.position = new Vector3(spawnPointEnemy.transform.position.x, spawnPointEnemy.transform.position.y, 0);
        cloneEnemy.transform.SetParent(parent);
        cloneEnemy.transform.localScale = new Vector3(1, 1, 1);



        clone.SetActive(true);
        cloneEnemy.SetActive(true);
        

    }
    void Update()
    {

        

    }


}
