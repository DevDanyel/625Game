using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject GoodObjectPrefab;

    void Start(){
        StartCoroutine(SpawnWave(6));
    }

    IEnumerator SpawnWave(int waveSize){
        yield return new WaitForSeconds(5);
        for(int i = 0; i <= waveSize; i++){
            Instantiate(GoodObjectPrefab, new Vector3(Random.Range(2, -2), 3, 0), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }

}
