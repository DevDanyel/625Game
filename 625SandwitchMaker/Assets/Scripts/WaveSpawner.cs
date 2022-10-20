using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject GoodObjectPrefab;
    public GameObject BadObjectPrefab;
    public GameObject topbread;


    void OnEnable(){
        StartCoroutine(SpawnWave(100));
    }

    IEnumerator SpawnWave(int waveSize){
        int goodOrBad = Random.Range(0, 1);
        yield return new WaitForSeconds(3);     //create a count down for when starting the game.
        for(int i = 0; i <= waveSize; i++){
            switch (goodOrBad) {
                case 0:
                Instantiate(GoodObjectPrefab, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);
                break; 
                case 1: 
                Instantiate(BadObjectPrefab, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);
                break;
            }
            yield return new WaitForSeconds(Random.Range(0, 5));
        }
        Instantiate(topbread, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);
    }





}
