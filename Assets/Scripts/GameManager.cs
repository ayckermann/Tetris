using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{

    Board board;   
    public Text scoreText;

    private int _score;
  

    public void Score(int lineCleared){
        _score+= lineCleared * 100;
        scoreText.text =_score.ToString();
        
    }
 

    public void GameOver(){
        board.tilemap.ClearAllTiles();
        //SceneManager.LoadScene(0);
    }


    
}
