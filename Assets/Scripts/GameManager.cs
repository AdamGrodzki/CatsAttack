using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text score;
    
    int points = 0;

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
