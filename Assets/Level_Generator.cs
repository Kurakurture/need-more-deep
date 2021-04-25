using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generator : MonoBehaviour
{
    public float currentHeight;
    public float levelHeight;
    
    public List<GameObject> dungeonList;
    public GameObject spawnTrigger;

    public GameObject lastSpawnTrigger;

    public void SpawnNextLevel()
    {
        Instantiate(dungeonList[Random.Range(0, dungeonList.Count)],new Vector3(0,currentHeight,0),Quaternion.identity);
        lastSpawnTrigger = Instantiate(spawnTrigger,new Vector3(0,currentHeight,0),Quaternion.identity);
        currentHeight -=levelHeight;
    }
}
