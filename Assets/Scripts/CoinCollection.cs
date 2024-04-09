 using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    // Start is called before the first frame update
    private int Coin = 0;
    public TextMeshProUGUI coinText;

    private void Start()
    {
        float spawnPointX = Random.Range(-4, 3.7f);
        float spawnPointY = Random.Range(1f, 2.5f);
        float spawnPointZ = Random.Range(-8, 0);

        Vector3 SpawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        float SpawnAngleY = Random.Range(0f, 180f);
        Instantiate(CoinToCreate, SpawnPosition, Quaternion.Euler(new Vector3(0, SpawnAngleY, 90)));
    }

    public GameObject CoinToCreate;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Coin")
        {
            
            Coin++;
            Destroy(other.gameObject);

            float spawnPointX = Random.Range(-4, 3.7f);
            float spawnPointY = Random.Range(1f, 2.5f);
            float spawnPointZ = Random.Range(-8, 0);

            Vector3 SpawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
            float SpawnAngleY = Random.Range(0f, 180f);

            Instantiate(CoinToCreate, SpawnPosition, Quaternion.Euler(new Vector3(0, SpawnAngleY, 90)));

            coinText.text = "Coin: " + Coin.ToString();

        }

        if (Coin % 10 == 0)
        {
            float spawnPointX = Random.Range(-4, 3.7f);
            float spawnPointY = Random.Range(1f, 2.5f);
            float spawnPointZ = Random.Range(-8, 0);

            Vector3 SpawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);
            float SpawnAngleY = Random.Range(0f, 180f);

            Instantiate(CoinToCreate, SpawnPosition, Quaternion.Euler(new Vector3(0, SpawnAngleY, 90)));

            coinText.text = "Coin: " + Coin.ToString();
        }
    }
}
