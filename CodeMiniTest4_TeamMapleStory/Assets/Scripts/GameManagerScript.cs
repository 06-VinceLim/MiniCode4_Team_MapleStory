using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject Coin;
    public int numberOfSpawn;
    public int AddCoin;
    public int CoinCollected;
    public GameObject CoinCount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfSpawn; i++)
        {
            Vector3 randomPos = new Vector3(Random.Range(-4, 4), 0.5f, Random.Range(-4, 4));
            Instantiate(Coin, randomPos, Quaternion.identity);
        }
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CoinCount.GetComponent<Text>().text = "Coin Collected " + CoinCollected;
    }
    public void SpawnCaps()
    {
            for (int i = 0; i < AddCoin; i++)
            {
                Vector3 randomPos = new Vector3(Random.Range(-4, 4),
                                                0.5f,
                                                Random.Range(-4, 4));
            Instantiate(Coin, randomPos, Quaternion.identity);
        }
    }
}
