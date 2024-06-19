using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public bool autoShoot = false;
    public float shootingRate = 2f;
    public float multiShotRate = 0.2f;
    public int multiShotAmount = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("StartMultiShooting",2,shootingRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartMultiShooting()
    {
        StartCoroutine(MultiShot(multiShotAmount,multiShotRate));
    }

    void Shoot()
    {
        var clon = Instantiate(bulletPrefab,transform.position,transform.rotation);
        Destroy(clon,2);
    }

    IEnumerator MultiShot(int amount, float rate)
    {
        int count = 0;
        while (count < amount)
        {
            Shoot();
            yield return new WaitForSeconds(rate);
            count++;
        }        
    }


}
