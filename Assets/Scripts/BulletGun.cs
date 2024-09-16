using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BulletGun : MonoBehaviour
{
    Vector2 Speed = new Vector2(3, 0);
    float Cooldown = 0.5f;
    float Shoot = 0;
    [SerializeField] private GameObject PlayerBullet;
    private void Start() {
        
    }
    private void Update() {
        
    }
    public void Fire() {
        if (Time.time >= Shoot && GetComponent<PlayerAvatar>().Energy > 0)
        {
            GameObject bullet =  Instantiate(PlayerBullet);
            SimpleBullet bulletComponent = bullet.GetComponent<SimpleBullet>();
            if (bulletComponent != null)
            {
                bulletComponent.Init(1, Speed, transform.position, BulletType.Player);
                GetComponent<PlayerAvatar>().Energy -= 1;
            }
            Shoot = Time.time + Cooldown;
        }
        
    }
}
