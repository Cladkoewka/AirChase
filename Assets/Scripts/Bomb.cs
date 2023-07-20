using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private AudioSource bombSound;
    public GameObject BombExplosionEffect;

    private void Awake()
    {
        bombSound = FindObjectOfType<Generator>().gameObject.GetComponent<AudioSource>();
    }
    public void Die()
    {
        bombSound.Play();
        Instantiate(BombExplosionEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
