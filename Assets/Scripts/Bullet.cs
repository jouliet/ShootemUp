using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    float Damage;
    Vector2 Speed;
    Vector2 Position;
    BulletType BulletType;

    public virtual void Init(float damage, Vector2 speed, Vector2 position, BulletType bulletType) {
        Damage = damage;
        Speed = speed;
        Position = position;
        transform.position = position;
        BulletType = bulletType;
    }

    public virtual void UpdatePosition() {
        Position += Speed * Time.deltaTime;
        transform.position = Position;
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        //bullet hits other bullet
        Bullet otherBullet = other.gameObject.GetComponent<Bullet>();
        if (otherBullet != null) {
            if (otherBullet.BulletType != BulletType) {
                Destroy(otherBullet.gameObject);
                Destroy(gameObject);
            }
        }
        //player bullet hits enemy
        if (BulletType == BulletType.Player) {
            EnemyAvatar enemy = other.gameObject.GetComponent<EnemyAvatar>();
            if (enemy != null)
            {
                enemy.TakeDamage(Damage);
                Destroy(gameObject);
            }
        }
         //enemy bullet hits player
        if (BulletType == BulletType.EnemyBullet) {
            PlayerAvatar player = other.gameObject.GetComponent<PlayerAvatar>();
            if (player != null)
            {
                player.TakeDamage(Damage);
                Destroy(gameObject);
            }
        }
    }
}
