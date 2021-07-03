using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SpawnerManager : MonoBehaviour
{
    [SerializeField] SpawnRock spawnRock;
    private float timerRock;
    private float time;

    private void Start()
    {
        timerRock = 0.1f;
        time = 0;
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time > timerRock)
            MonsterSpawn();
    }

    void MonsterSpawn()
    {
        spawnRock.SpawnRocks();
        time = 0;
    }
}