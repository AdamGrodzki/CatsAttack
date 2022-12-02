using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text score;
    int points = 0;

    void Start()
    {
        score.text = PlayerPrefs.GetInt("Score", 0).ToString();    
    }
    public void AddPoint()
    {
        PlayerPrefs.SetInt("Score", points);
        print(points);
        points++;
        score.text = points.ToString();
    }
    public void ResetPoints()
    {
        PlayerPrefs.DeleteKey("Score");
    }
    public void GameOver()
    {  
        SceneManager.LoadScene(2);
    }
  

}
