using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    AudioSource audioS; 
   
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            createBulletOnTheScene();
        }
    }
    void createBulletOnTheScene()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = gameObject.transform.position;
        audioS.Play();
    } 
}
