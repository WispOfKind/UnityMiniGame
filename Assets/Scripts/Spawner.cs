using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Coin;
    
    public void SpawnCoin()
    {
        int spawnPointX = Random.Range(-2, 3);
        int spawnPointY = 5;
        int spawnPointZ = Random.Range(-2, 3);

        Vector3 SpawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        Instantiate(Coin, SpawnPosition, Quaternion.identity);

    }

    
}
