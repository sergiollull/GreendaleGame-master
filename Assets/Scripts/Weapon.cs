using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject beamPrefab;
    public Transform parent;
    public GameObject beamClone;

    // Update is called once per frame
    void Start()
    {
        beamClone = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Shooting");
            Shoot();
        }
    }
    void Shoot()
    {
        beamClone = Instantiate(beamPrefab, firePoint.position, firePoint.rotation);
        beamClone.transform.SetParent(parent);
    }

}
