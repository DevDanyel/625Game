using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public Sprite[] experimentEmots;
    public SpriteRenderer  experimentSkin;
    public GameObject Playbtn;
    public GameObject pauseBtn;

    public HealthBar hb;
    public sandwitchScript ss;
    public WaveSpawner ws;
    public GameObject startScreen;
    public GameObject HowToPlayScreen;
    public GameObject transisionScreen;
    public GameObject EndGameScreen;
    public GameObject spawner;

    public GameObject healthBar;

    public TextMeshProUGUI score;
    public TextMeshProUGUI EndGameScore;
    public int currScore;
    public int finalScore;
    public TextMeshProUGUI levelNum;
    public int currLevel;
    

    void Start(){
        EndGameScreen.SetActive(false);
        startScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
        healthBar.SetActive(false);
        Playbtn.SetActive(false);
        pauseBtn.SetActive(false);
        currLevel = 0;
        levelNum.text = "LEVEL" + currLevel;
        experimentSkin.sprite = experimentEmots[0];
    }

    void Update(){
        if(ss.currStackNum == 6){
            EndGame();
        }
    }

    public void startGame(){
        experimentSkin.sprite = experimentEmots[0];
        EndGameScreen.SetActive(false);
        startScreen.SetActive(false);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(true);
        transisionScreen.SetActive(false);
        healthBar.SetActive(true);
        Playbtn.SetActive(false);
        pauseBtn.SetActive(true);

    }

    public void HowToPlay(){
        HowToPlayScreen.SetActive(true);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
        EndGameScreen.SetActive(false);
        healthBar.SetActive(false);
    }
    
    public void PauseBtn(){
        experimentSkin.sprite = experimentEmots[1];// make this screen the pause screen and thats it
        startScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
        EndGameScreen.SetActive(false);
        healthBar.SetActive(false);
        Playbtn.SetActive(true);
        pauseBtn.SetActive(false);
    }
    

    /* // not done yet this one needs a lot more 
    public void QuitBtn(){
        HowToPlayScreen.SetActive(true);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
        EndGameScreen.SetActive(false);
        healthBar.SetActive(false);
    }
    */

    public void NextLevel(){
        EndGameScreen.SetActive(false);
        transisionScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        levelNum.text = "LEVEL" + currLevel;
        currLevel++;
        score.text = ""+currScore;
        ss.RestartStack();
        healthBar.SetActive(false);
        if(ws.waveSpeed !> 3.2){
            ws.waveSpeed *= .9f;
        }
        
    }

    public void IncScore(int value){
        currScore += value;
    }

    public void EndGame(){
        EndGameScreen.SetActive(true);
        transisionScreen.SetActive(false);
        HowToPlayScreen.SetActive(false);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        finalScore += currScore;
        score.text = ""+currScore;
        EndGameScore.text = ""+finalScore;
        ss.RestartStack();
        healthBar.SetActive(false);
        currScore =0;
        hb.P2Health = hb.maxHealth;
        hb.UpdateHealth(hb.maxHealth, hb.P2Health);
    }


}
