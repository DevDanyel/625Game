using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwitchScript : MonoBehaviour
{
    public HealthBar hb;
    public GameObject[] stackedSandwitch;
    public Sprite[] goodIngre;

    public GameManager gm;

    public PrefabScript ps;
    public int currStackNum;

    void Start(){
        currStackNum = 0;
    }



    void UpdateStackNum(){
        if(currStackNum <= 6){
            currStackNum++;
            //would also like to extend the reach of the collider
            
        }
    }


    void AddToStack(int ingreNum){
        stackedSandwitch[currStackNum].GetComponent<SpriteRenderer>().sprite = goodIngre[ingreNum];
        UpdateStackNum();
    }

    public void RestartStack(){
        foreach (GameObject ingr in stackedSandwitch)
        {
            ingr.GetComponent<SpriteRenderer>().sprite = null;
        }
        currStackNum = 0;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("TopBread")){
            //call gamemanager next level 
            gm.NextLevel();
        }

        if(col.CompareTag("badIngre")){
            hb.LoseHealth(10);
        }
        
        if(col.CompareTag("GoodIngre")){
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_0"){  //bacon
                AddToStack(0);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_1"){  //onions
                AddToStack(1);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_2"){   //cheese
                AddToStack(2);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_3"){   //tomatoes
                AddToStack(3);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_4"){  //Ham
                AddToStack(4);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_5" || col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_6" ){  //mayo must
                AddToStack(5);
                gm.IncScore(20);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_7"){  //pickles
                AddToStack(6);
                gm.IncScore(20);
            }

            
            Debug.Log(col.GetComponent<SpriteRenderer>().sprite.name);
        }
    }
}
