using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour
{
    [SerializeField] private float _maxSpeed;
    protected float maxHealth;
    protected float health;
    public bool isDead;

    public float MaxSpeed {
        get {
        return this._maxSpeed;
        }
        private set {
        this._maxSpeed = value;
        }
    }

    public float Health {
        get {
            return this.health;
        }
    }
    public float MaxHealth {
        get {
            return this.maxHealth;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            Die();
        }
    }

    public virtual void Die() {
        health = 0;
        isDead = true;
        Destroy(gameObject);
    }
}
