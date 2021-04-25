using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Generator : MonoBehaviour
{
    public float currentHeight;
    public int currentLevel = 0;
    public float levelHeight;

    public List<GameObject> dungeonList;
    public GameObject spawnTrigger;

    public GameObject lastSpawnTrigger;

    public bool random = false;

    public void SpawnNextLevel()
    {
        if (random) { Instantiate(dungeonList[Random.Range(0, dungeonList.Count)], new Vector3(0, currentHeight, 0), Quaternion.identity); }
        else
        {
            Instantiate(dungeonList[currentLevel], new Vector3(0, currentHeight, 0), Quaternion.identity);
            currentLevel++;
        }

        lastSpawnTrigger = Instantiate(spawnTrigger, new Vector3(0, currentHeight, 0), Quaternion.identity);
        currentHeight -= levelHeight;
    }

    private void Update()
    {
        if (Input.GetKey("r"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
