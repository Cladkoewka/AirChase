using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject CoinPrefab;
    public GameObject BombPrefab;

    public int CountCoins = 0;

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
                Vector3 place = new Vector3(i * 2, Random.Range(-30f, 30f), 0);
                if(Random.Range(0,4) == 0)
                {
                    Instantiate(BombPrefab, place, Quaternion.identity);
                }
                else
                {
                    Instantiate(CoinPrefab, place, Quaternion.identity);
                    CountCoins++;
                }
        }
    }
}
