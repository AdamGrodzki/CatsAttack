using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject catPrefab;
    [SerializeField] Transform[] spawnPosition;
    [SerializeField] Text score;
    
    int points = 0;
 
    void Start()
    {
        InvokeRepeating("SpawnCat", 1.5f, 1.5f);
    }
    void SpawnCat()
    {
        GameObject cat = Instantiate(catPrefab);
        int randomNumber = Random.Range(0, spawnPosition.Length);
        cat.transform.position = spawnPosition[randomNumber].transform.position;
    }
    public void AddPoint()
    {
        points++;
        score.text = points.ToString();
    }
    public void GameOver()
    {   

        SceneManager.LoadScene(2);
    }
  

}
