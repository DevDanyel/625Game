using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject GoodObjectPrefab;
    public GameObject BadObjectPrefab;
    public GameObject topbread;
    public float waveSpeed;

    void Start(){
        waveSpeed = 5;
    }

    void OnEnable(){
        StartCoroutine(SpawnWave(100, waveSpeed));
    }

    IEnumerator SpawnWave(int waveSize, float ws){
        float goodOrBad = Random.Range(1f, 2f);
        yield return new WaitForSeconds(3);     //create a count down for when starting the game.
        for(int i = 0; i <= waveSize; i++){
            if(goodOrBad >= 1.5f){
                Instantiate(GoodObjectPrefab, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);

            }else if(goodOrBad < 1.5f){
                Instantiate(BadObjectPrefab, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);

            }
            //turn the 7 into a variable later so when levels get higher you have to wait longer to finish
            if(i%7 == 0){
                Instantiate(topbread, new Vector3(Random.Range(2f, -2f), 3, 0), Quaternion.identity);
            }
            Debug.Log("i:"+ i+ "  |  i/7: " + i/7 +" |  GoodOrBad:"+ goodOrBad );
            yield return new WaitForSeconds(Random.Range(3f, ws));
            goodOrBad = Random.Range(0, 1);
        }
        
    }





}
