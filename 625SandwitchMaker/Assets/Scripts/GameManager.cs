using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public sandwitchScript ss;
    public GameObject startScreen;
    public GameObject HowToPlayScreen;
    public GameObject transisionScreen;
    public GameObject spawner;

    public TextMeshProUGUI score;
    public int currScore;
    public TextMeshProUGUI levelNum;
    public int currLevel;
    

    void Start(){
        startScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
        currLevel = 0;
        levelNum.text = "LEVEL" + currLevel;
    }

    public void startGame(){
        startScreen.SetActive(false);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(true);
        transisionScreen.SetActive(false);

    }

    public void HowToPlay(){
        HowToPlayScreen.SetActive(true);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        transisionScreen.SetActive(false);
    }

    public void NextLevel(){
        transisionScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        startScreen.SetActive(false);
        spawner.SetActive(false);
        levelNum.text = "LEVEL" + currLevel;
        currLevel++;
        score.text = ""+currScore;
        ss.RestartStack();
    }

    public void IncScore(int value){
        currScore += value;
    }


}
