using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBasicBulletGun : Bullet
{
    float Cooldown;
    float Shoot;
    [SerializeField] private GameObject EnemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        Cooldown = 4;
        Shoot = Time.time + 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= Shoot)
        {
            GameObject bullet =  Instantiate(EnemyBullet);
            SimpleBullet bulletComponent = bullet.GetComponent<SimpleBullet>();
            if (bulletComponent != null)
            {
                bulletComponent.Init(1, new Vector2(-4, 0), gameObject.transform.position, BulletType.EnemyBullet);
            }
            Shoot = Time.time + Cooldown;
        }
    }
}
