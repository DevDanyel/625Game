using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject GoodObjectPrefab;

    void Start(){
        StartCoroutine(ExampleCoroutine());
        SpawnWave(6);
    }

    void SpawnWave(int waveSize){
        for(int i = 0; i <= waveSize; i++){
            Instantiate(GoodObjectPrefab, new Vector3(Random.Range(2, -2), 3, 0), Quaternion.identity);
            StartCoroutine(ExampleCoroutine());
        }
    }


    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
    }
}
