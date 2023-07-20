using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource coinSound;

    private void Awake()
    {
        coinSound = FindObjectOfType<Score>().gameObject.GetComponent<AudioSource>();
    }
    public void Die()
    {
        coinSound.Play();
        Destroy(gameObject);
    }
}
