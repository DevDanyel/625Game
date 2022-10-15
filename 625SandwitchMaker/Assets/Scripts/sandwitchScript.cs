using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwitchScript : MonoBehaviour
{
    public GameObject[] stackedSandwitch;
    public Sprite[] goodIngre;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("GoodIngre")){
            stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[0];
        }
    }
}
