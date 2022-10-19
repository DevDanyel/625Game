using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image P2HealthBar;
    public GameManager gm;

    public float maxHealth = 30;
    public float P2Health;

    void Start(){
        P2Health = maxHealth;
        P2HealthBar.fillAmount = 0;
    }

    public void LoseHealth(float hitPower){
        P2Health -= hitPower;
        UpdateHealth(maxHealth, P2Health);
    }

    public void UpdateHealth(float mHealth, float CHealth){
        P2HealthBar.fillAmount = CHealth / mHealth;
    }

    void Update(){
        if(P2Health == 0){
            gm.EndGame();
        }
    }
    

}
