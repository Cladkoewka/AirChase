using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Coins;
    public TMP_Text CoinsText;
    public TMP_Text HPText;
    public GameObject WinScreen;

    private Generator generator;
    private Airplane airplane;

    private void Start()
    {
        generator = FindObjectOfType<Generator>();
        airplane = FindObjectOfType<Airplane>();
        CoinsText.text = "0/" + generator.CountCoins.ToString();
    }
    public void AddOne()
    {
        Coins ++;
        CoinsText.text = Coins.ToString() + "/" + generator.CountCoins.ToString();
        if (Coins == generator.CountCoins) 
        { 
            WinScreen.SetActive(true);
        }
    }

    public void UpdateHP(int health)
    {
        HPText.text = health.ToString() + "/5";
    }
}
