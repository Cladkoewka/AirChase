using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= 10 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        if (bomb)
        {
            bomb.Die();
            Destroy(gameObject);
        }
    }
}
