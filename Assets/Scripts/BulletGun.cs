using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BulletGun : MonoBehaviour
{
    Vector2 Speed;
    float Cooldown = 0.5f;
    float Shoot = 0;
    [SerializeField] private GameObject PlayerBullet;
    public void Fire() {
        if (Time.time >= Shoot)
        {
            GameObject bullet =  Instantiate(PlayerBullet);
            SimpleBullet bulletComponent = bullet.GetComponent<SimpleBullet>();
            if (bulletComponent != null)
            {
                bulletComponent.Init(1, new Vector2(3, 0), transform.position, BulletType.Player);
            }
            Shoot = Time.time + Cooldown;
        }
        
    }
}
