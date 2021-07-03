using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnRock : MonoBehaviour
{
    enum Rock { rockBig, rockFlat, rockSmall }
    Rock rockSpawned;

    [SerializeField] GameObject prefabRockBig;
    [SerializeField] GameObject prefabRockFlat;
    [SerializeField] GameObject prefabRockSmall;
    [SerializeField] float lateralLimitSpawn = 4.0f;
    public void SpawnRocks()
    {
        int randomNuber = Random.Range(0, 3);
        rockSpawned = (Rock)randomNuber;

        switch (rockSpawned)
        {
            case Rock.rockBig:
                {
                    Vector3 position = new Vector3(Random.Range(-lateralLimitSpawn, lateralLimitSpawn), 0, 0);
                    Instantiate(prefabRockBig, position, Quaternion.identity);
                }
                break;
            case Rock.rockFlat:
                {
                    Vector3 position = new Vector3(Random.Range(-lateralLimitSpawn, lateralLimitSpawn), 0, 0);
                    Instantiate(prefabRockFlat, position, Quaternion.identity);
                }
                break;
            case Rock.rockSmall:
                {
                    Vector3 position = new Vector3(Random.Range(-lateralLimitSpawn, lateralLimitSpawn), 0, 0);
                    Instantiate(prefabRockSmall, position, Quaternion.identity);
                }
                break;
        }
    }
}
