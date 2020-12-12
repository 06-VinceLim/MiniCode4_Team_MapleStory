using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Controller : MonoBehaviour
{
    public int CoinCollected;
    public GameObject CoinCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        CoinCount.GetComponent<Text>().text = "Coin Collected " + CoinCollected;
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            CoinCollected++;
            if (CoinCollected < 30)
            {
                GameManagerScript.instance.SpawnCaps();
            }
            else if (CoinCollected >= 30)
            {
                Destroy(GameObject.FindGameObjectWithTag("Wall"));
            }
        }
    }
}
