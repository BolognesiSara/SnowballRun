using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnRock : MonoBehaviour
{
    enum rock { rockBig, rockFlat, rockSmall }
    rock rockSpawned;

    [SerializeField] GameObject prefabRockBig;
    [SerializeField] GameObject prefabRockFlat;
    [SerializeField] GameObject prefabRockSmall;
    public void SpawnRocks()
    {
        int randomNuber = Random.Range(0, 3);
        Debug.Log(randomNuber);
        rockSpawned = (rock)randomNuber;

        switch (rockSpawned)
        {
            case rock.rockBig:
                {
                    Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 0, 0);
                    Instantiate(prefabRockBig, position, Quaternion.identity);
                }
                break;
            case rock.rockFlat:
                {
                    Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 0, 0);
                    Instantiate(prefabRockFlat, position, Quaternion.identity);
                }
                break;
            case rock.rockSmall:
                {
                    Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 0, 0);
                    Instantiate(prefabRockSmall, position, Quaternion.identity);
                }
                break;
        }
    }
}
