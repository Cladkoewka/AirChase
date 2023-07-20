using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject BulletPrefab;
    public AudioSource ShotSound;
    public float BulletSpeed;
    public float GunRecoil;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && _timer >= GunRecoil)
        {
            CreateBullet();
            _timer = 0;
        }
    }


    private void CreateBullet()
    {
        GameObject newBullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody>().velocity = transform.right * BulletSpeed;
        ShotSound.pitch = Random.Range(0.8f, 1);
        ShotSound.Play();
    }
}
