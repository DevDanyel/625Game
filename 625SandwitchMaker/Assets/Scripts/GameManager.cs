using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject spawner;

    void Start(){
        startScreen.SetActive(true);
        spawner.SetActive(false);
    }

    public void startGame(){
        startScreen.SetActive(false);
        spawner.SetActive(true);
    }


}
