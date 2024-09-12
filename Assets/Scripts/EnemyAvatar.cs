using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAvatar : BaseAvatar
{
    float damage;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 1;
        health = maxHealth;
        damage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other) {
        //enemy hits player
        PlayerAvatar player = other.gameObject.GetComponent<PlayerAvatar>();
        if (player != null) {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
