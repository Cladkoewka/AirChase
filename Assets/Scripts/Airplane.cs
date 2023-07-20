using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public int Health;
    public Score Score;

    public AudioSource HitSound;
    public AudioSource DeadSound;
    public GameObject DeadEffect;
    public GameObject GameOverScreen;

    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            TakeDamage();
            bomb.Die();
        }

        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            Score.AddOne();
            coin.Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Wall wall = collision.gameObject.GetComponent<Wall>();
        if (wall)
        {
            HitSound.Play();
            //Hit effect
        }
    }

    private void TakeDamage()
    {
        Health--;
        Score.UpdateHP(Health);
        if (Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        DeadSound.Play();
        Instantiate(DeadEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        GameOverScreen.SetActive(true);
    }
}
