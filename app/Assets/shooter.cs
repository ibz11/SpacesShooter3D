using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shooter : MonoBehaviour
{

 
    // public AudioSource aliensound;







    // Start is called before the first frame update
 public Transform bulletSpawnPoint1;
 //public Transform bulletSpawnPoint2;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20;
 // , bulletSpawnPoint2.position, bulletSpawnPoint2.rotation
    void Update()
    {
        if(Input.GetKeyDown("l"))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint1.forward * bulletSpeed;
            // Destroy(bullet,3);
            //  bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint2.forward * bulletSpeed;
     
        }
    }

    //     public void OnTriggerEnter(Collider Col)
    // {
    //       if (Col.gameObject.tag == "alien"){
    //          aliensound.Stop();
    //         // aliensound.audioSource.SetActive(false);
    // }}
}
