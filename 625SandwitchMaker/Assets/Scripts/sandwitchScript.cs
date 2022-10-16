using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwitchScript : MonoBehaviour
{
    public GameObject[] stackedSandwitch;
    public Sprite[] goodIngre;

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

        //if over max then would call an end game function or something. 
    }


    void AddToStack(int ingreNum){
        stackedSandwitch[currStackNum].GetComponent<SpriteRenderer>().sprite = goodIngre[ingreNum];
        UpdateStackNum();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("GoodIngre")){
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_0"){  //bacon
                AddToStack(0);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_1"){  //onions
                AddToStack(1);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_2"){   //cheese
                AddToStack(2);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_3"){   //tomatoes
                AddToStack(3);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_4"){  //Ham
                AddToStack(4);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_5" || col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_6" ){  //mayo must
                AddToStack(5);
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_7"){  //pickles
                AddToStack(6);
            }

            
            Debug.Log(col.GetComponent<SpriteRenderer>().sprite.name);
        }
    }
}
