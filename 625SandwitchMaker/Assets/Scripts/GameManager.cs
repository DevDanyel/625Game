using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject HowToPlayScreen;
    public GameObject spawner;

    void Start(){
        startScreen.SetActive(true);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(false);
    }

    public void startGame(){
        startScreen.SetActive(false);
        HowToPlayScreen.SetActive(false);
        spawner.SetActive(true);
    }

    public void HowToPlay(){
        HowToPlayScreen.SetActive(true);
        startScreen.SetActive(false);
    }


}
