using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cat : MonoBehaviour
{
    GameObject player;
    GameObject GameManager;
    Vector3 positionPlayer;
    Vector3 direction;
    AudioSource audioSource;
    float speed = 5f;
  
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        GameManager = GameObject.FindWithTag("GameManager");
        audioSource = GetComponent<AudioSource>();
        ChangePitchSound();
    }
    void Update()
    {
        FindPlayer();
        MoveToPlayer();
        
    }
    void ChangePitchSound()
    {
        float randomNumber = Random.Range(0.5f, 2.0f);
        audioSource.pitch = randomNumber;
    }

    void FindPlayer()
    {   if(player !=null)
        {
        positionPlayer = player.transform.position;
        }
    }
    void MoveToPlayer()
    {
       direction = positionPlayer - transform.position;
        transform.position += direction.normalized*speed*Time.deltaTime;  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            GameManager.GetComponent<GameManager>().AddPoint();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            GameManager.GetComponent<GameManager>().GameOver();
        }
    }
}
