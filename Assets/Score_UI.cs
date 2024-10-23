using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_UI : MonoBehaviour
{
    // Start is called before the first frame update
    public int score ;
    public Text scoretxt;
    public GameObject over_scene;

    
    [ContextMenu("Increase Score")]
    public void addScore(int point)
    {
        score += point;
        scoretxt.text = $"{score}";
    }
    
    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void game_over()
    {
        over_scene.SetActive(true);
    }

    public int getScore(){
        return score;
        
    }
}
