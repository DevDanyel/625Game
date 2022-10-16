using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandwitchScript : MonoBehaviour
{
    public GameObject[] stackedSandwitch;
    public Sprite[] goodIngre;

    public PrefabScript ps;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("GoodIngre")){
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_0"){  //bacon
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[0];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_1"){  //onions
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[1];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_2"){   //cheese
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[2];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_3"){   //tomatoes
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[3];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_4"){  //Ham
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[4];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_5" || col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_6" ){  //mayo must
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[5];
            }
            if(col.GetComponent<SpriteRenderer>().sprite.name == "ingrediants_7"){  //pickles
                stackedSandwitch[0].GetComponent<SpriteRenderer>().sprite = goodIngre[6];
            }

            
            Debug.Log(col.GetComponent<SpriteRenderer>().sprite.name);
        }
    }
}
