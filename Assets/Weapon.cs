using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float force;

    new AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Shoot();
    }

    void Shoot()
    {
        GameObject bulletClone = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody bulletRB = bulletClone.GetComponent<Rigidbody>();

        bulletRB.AddRelativeForce(transform.forward * force, ForceMode.Impulse);

        audio.Play();
        Destroy(bulletClone, 5f);
    }
}
